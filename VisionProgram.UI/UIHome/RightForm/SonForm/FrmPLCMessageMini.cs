using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass;

namespace VisionProgram.UI.UIHome.RightForm
{
    /// <summary>
    /// 显示在主界面右侧面板 与plc交互信息迷你窗口
    /// </summary>
    public partial class FrmPLCMessageMini : Form
    {
        private VisionProgram.UserControls.UIListView.ListViewEX[] _listViewArray = new VisionProgram.UserControls.UIListView.ListViewEX[Project.Instance().PLCManagerInstance.PLCNum];
        //锁对象
        //因此类向外界提供单例，因此给对象加锁也能起到给类加锁的作用
        object obj = new object();

        private List<ToolStripButton> _tsButtonList = new List<ToolStripButton>();


        //展示信息委托
        private delegate void UpdateControls(string msg, int plcIndex, string time, bool isOK = true);
        private UpdateControls _upd = null;

        internal Action<int> OnClearMessageMinEvent;
        internal Action OnSetPLCMessageFormNormalEvent;


        #region 构造 单例
        /// <summary>
        /// 私有构造器
        /// </summary>
        private FrmPLCMessageMini()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            NoticeHelper.OnPLCMessageRecieved += PLCMessageMinReceived;
            _upd = new UpdateControls(OutputPLCMsg);

            this.InitControl();
        }


        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmPLCMessageMini _instance;
        public static FrmPLCMessageMini Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmPLCMessageMini();
                return _instance;
            }
        }
        #endregion

        #region 窗体事件
        private void FrmPLCMessageMini_SizeChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < _listViewArray.Length; i++)
            {
                if (i > 0)
                    _listViewArray[i].Size = this.ListView1.Size;
                _listViewArray[i].Columns[1].Width = _listViewArray[i].Width - _listViewArray[i].Columns[0].Width - 10;
            }
        }
        #endregion

        #region 渲染方法
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControl()
        {
            SplitContainer1.SplitterWidth = 1;


            //先加载默认的一个PLC的ListView
            _listViewArray[0] = this.ListView1;

            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                     this.放大窗口ToolStripMenuItem,
                     this.清屏PLC1ToolStripMenuItem});

            清屏PLC1ToolStripMenuItem.Click += (o, e) => { 清屏PLCToolStripMenuItem_Click(this, new MyEventArgs(0)); };
            ToolStripButton1.Click += (o, e) => { SwitchListView_Click(this, new MyEventArgs(new string[] { "0", ToolStripButton1.Name })); };
            _tsButtonList.Clear();
            _tsButtonList.Add(ToolStripButton1);
            this.InitAllMessageListViewPage();
            for (int i = 0; i < _listViewArray.Length; i++)
                this.SplitContainer1.Panel2.Controls.Add(_listViewArray[i]);
            // this.PanelMain.Controls.Add(_listViewArray[i]);
            ToolStripButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            ToolStripButton1.PerformClick();
        }

        /// <summary>
        /// 根据PLC的个数把剩下的ListView动态渲染出来
        /// </summary>
        private void InitAllMessageListViewPage()
        {
            //判断是否多PLC，动态加载另外的PLC的信息显示框
            if (Project.Instance().PLCManagerInstance.PLCNum > 1)
            {
                for (int i = 1; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
                {
                    //注意直接在匿名回调方法中或者lambda表达式中使用循环体中的增值变量i，得到的外部的值
                    //因为C#后台在回调方法执行之前就提前存储了该回调方法使用的外部变量
                    int index = i;

                    ToolStripButton tsButton = new ToolStripButton();
                    tsButton.CheckOnClick = ToolStripButton1.CheckOnClick;
                    tsButton.BackColor = Color.Transparent;
                    tsButton.Font = ToolStripButton1.Font;
                    tsButton.DisplayStyle = ToolStripButton1.DisplayStyle;
                    tsButton.ForeColor = ToolStripButton1.ForeColor;
                    tsButton.ImageTransparentColor = ToolStripButton1.ImageTransparentColor;
                    tsButton.Name = $"ToolStripButton{i + 1}";
                    tsButton.Size = ToolStripButton1.Size;
                    tsButton.Text = $"PLC{i + 1}";
                    tsButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    tsButton.Margin = ToolStripButton1.Margin;
                    tsButton.Click += (o, e) => { SwitchListView_Click(this, new MyEventArgs(new string[] { index + "", tsButton.Name })); };
                    this.ToolStrip1.Items.Add(tsButton);
                    _tsButtonList.Add(tsButton);

                    ToolStripLabel tsLabel = new ToolStripLabel();
                    tsLabel.Name = $"toolStripLabel{i + 1}";
                    tsLabel.Size = toolStripLabel1.Size;
                    tsLabel.Text = toolStripLabel1.Text;
                    this.ToolStrip1.Items.Add(tsLabel);

                    VisionProgram.UserControls.UIListView.ListViewEX lView = new VisionProgram.UserControls.UIListView.ListViewEX();
                    ColumnHeader cHeader1 = new ColumnHeader();
                    ColumnHeader cHeader2 = new ColumnHeader();
                    cHeader1.Text = "时间";
                    cHeader1.Width = this.ColumnHeader1.Width;
                    cHeader2.Text = "信息";
                    cHeader2.Width = this.ColumnHeader2.Width;

                    lView.BorderStyle = this.ListView1.BorderStyle;
                    lView.BackColor = this.ListView1.BackColor;
                    lView.Dock = this.ListView1.Dock;
                    lView.Font = this.ListView1.Font;
                    lView.ForeColor = this.ListView1.ForeColor;
                    lView.FullRowSelect = this.ListView1.FullRowSelect;
                    lView.HeaderStyle = this.ListView1.HeaderStyle;
                    lView.Location = this.ListView1.Location;
                    lView.Margin = this.ListView1.Margin;
                    lView.Name = "ListView" + (i + 1);
                    lView.ShowItemToolTips = this.ListView1.ShowItemToolTips;
                    lView.Size = this.ListView1.Size;
                    lView.UseCompatibleStateImageBehavior = this.ListView1.UseCompatibleStateImageBehavior;
                    lView.View = this.ListView1.View;
                    lView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { cHeader1, cHeader2 });
                    _listViewArray[i] = lView;

                    ToolStripMenuItem tsmItem = new ToolStripMenuItem();
                    tsmItem.Name = $"清屏PLC{i + 1}ToolStripMenuItem";
                    tsmItem.Size = this.清屏PLC1ToolStripMenuItem.Size;
                    tsmItem.Text = $"清屏PLC{i + 1}";
                    tsmItem.Click += (o, e) => { 清屏PLCToolStripMenuItem_Click(this, new MyEventArgs(index)); };
                    this.ContextMenuStrip1.Items.Add(tsmItem);
                }
            }
        }
        #endregion


        #region 显示信息方法
        public void PLCMessageMinReceived(string msg, int plcIndex, string time, bool isOK = true)
        {
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(_upd, msg, plcIndex, time, isOK);
            }
        }

        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="data"></param>
        /// <param name="plcIndex"></param>
        /// <param name="isOK"></param>
        public void OutputPLCMsg(string data, int plcIndex, string time, bool isOK = true)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return;

            Action<string, int, string> act = (msg, index, nowTime) =>
            {
                try
                {
                    lock (obj)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = nowTime;
                        item.SubItems.Add(msg);
                        item.ForeColor = isOK ? Color.Black : System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                        _listViewArray[index].Items.Add(item);
                        item.EnsureVisible();
                        //_listViewArray[index].EnsureVisible(_listViewArray[index].Items.Count - 1);
                        if (_listViewArray[index].Items.Count > Project.Instance().GlobalManagerInstance.GlobalParamModel.InteractionInfoMaxLines)
                            _listViewArray[index].Items.RemoveAt(0);
                        Application.DoEvents();
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("交互信息面板显示信息出现异常", ex);
                }

            };
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(act, data, plcIndex, time);
            }
        }
        #endregion



        #region 按钮方法
        /// <summary>
        /// 点击切换ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchListView_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            string[] data = (String[])args.obj;
            //this.PanelMain.Controls.Clear();
            for (int i = 0; i < this.ToolStrip1.Items.Count; i++)
            {
                if (this.ToolStrip1.Items[i].Name != data[1])
                    this.ToolStrip1.Items[i].BackColor = Color.Transparent;
                else
                    this.ToolStrip1.Items[i].BackColor = Color.CadetBlue;
            }
            for (int i = 0; i < _tsButtonList.Count; i++)
            {
                if (_tsButtonList[i].Name != data[1])
                    _listViewArray[i].Visible = false;
                else
                    _listViewArray[i].Visible = true;
            }

        }

        /// <summary>
        /// 点击放大窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 放大窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnSetPLCMessageFormNormalEvent?.Invoke();
        }


        private void 清屏PLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            int index = (int)args.obj;
            OnClearMessageMinEvent?.Invoke(index);
        }

        internal void ClearInfo(int index)
        {
            _listViewArray[index].Items.Clear();
        }
        #endregion


    }

}
