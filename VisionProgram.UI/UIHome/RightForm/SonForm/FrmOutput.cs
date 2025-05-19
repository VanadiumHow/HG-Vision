using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/

namespace VisionProgram.UI.UIHome.RightForm
{
    public partial class FrmOutput : Form
    {

        //展示信息委托
        private delegate void UpdateControls(string msg, int i);
        private UpdateControls _upd = null;

        private System.Drawing.Color[] _outPutItemColorArray = new System.Drawing.Color[]
        {
            System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(150)))), ((int)(((byte)(40))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))))
        };

        private FrmOutput()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            NoticeHelper.OnOutputMessageRecieved += OutputMessageReceived;
            _upd = new UpdateControls(OutputMsg);
        }


        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmOutput _instance;
        public static FrmOutput Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmOutput();
                return _instance;
            }
        }

        private List<OutputItem> _outputItemList = new List<OutputItem>();

        private int _numSum = 0;
        private int _numGreen = 0;
        private int _numYellow = 0;
        private int _numRed = 0;

        //锁对象
        object obj = new object();


        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="msg">信息内容</param>
        /// <param name="color">颜色显示</param>
        public void OutputMsg(string m, int i)
        {

            Action<string, int> act = (msg, index) =>
            {
                if (index > _outPutItemColorArray.Length - 1)
                {
                    return;
                }
                try
                {
                    lock (obj)
                    {
                        _numSum++;
                        if (msg == string.Empty)
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = string.Empty;
                            item.SubItems.Add(msg);
                            item.ForeColor = _outPutItemColorArray[index];
                            ListView1.Items.Add(item);
                        }
                        else
                        {
                            if (index == OutputLevelModel.WARN)
                                _numYellow++;
                            else if (index == OutputLevelModel.ERROR)
                                _numRed++;
                            else
                                _numGreen++;

                            string time = DateTime.Now.ToString("dd HH:mm:ss");

                            OutputItem outputItem = new OutputItem();
                            outputItem.colorIndex = index;
                            outputItem.msg = msg;
                            outputItem.color = _outPutItemColorArray[index];
                            outputItem.time = time;

                            _outputItemList.Add(outputItem);
                            // listView1.Columns[1].Width = listView1.Width - listView1.Columns[0].Width - 10;
                            ListViewItem item = new ListViewItem();
                            item.Text = time;
                            item.SubItems.Add(msg);
                            item.ForeColor = _outPutItemColorArray[index];
                            ListView1.Items.Add(item);
                            ListView1.EnsureVisible(ListView1.Items.Count - 1);
                            if (_outputItemList.Count > 1000)
                            {
                                if (_outputItemList[0].colorIndex == OutputLevelModel.WARN)
                                    _numYellow--;
                                else if (_outputItemList[0].colorIndex == OutputLevelModel.ERROR)
                                    _numRed--;
                                else
                                    _numGreen--;
                                _numSum--;
                                ListView1.Items.RemoveAt(0);
                                _outputItemList.RemoveAt(0);
                            }
                            UpdateCount();
                        }
                        Application.DoEvents();
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("Output窗体显示信息出现异常", ex);
                }

            };
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(act, m, i);
            }
        }

        /// <summary>
        /// 改变数量
        /// </summary>
        private void UpdateCount()
        {
            ToolTip1.SetToolTip(ButtonAll, $"全部({_numSum})");
            ToolTip1.SetToolTip(ButtonTip, $"提示({_numGreen})");
            ToolTip1.SetToolTip(ButtonWarn, $"警告({_numYellow})");
            ToolTip1.SetToolTip(ButtonError, $"错误({_numRed})");
        }


        private void Frm_Output_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 手动清除
        /// </summary>
        private void clear()
        {
            _numSum = 0;
            _numGreen = 0;
            _numRed = 0;
            _numYellow = 0;
            _outputItemList.Clear();
            ListView1.Items.Clear();
            UpdateCount();
        }

        /// <summary>
        /// 历史日志
        /// </summary>
        private void historyLog()
        {
            Process.Start(FilePathModel.LogPath);
        }


        private void Frm_Output_SizeChanged(object sender, EventArgs e)
        {
            ListView1.Columns[1].Width = ListView1.Width - ListView1.Columns[0].Width;
        }

        private void 清除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _outputItemList.Clear();
            clear();
        }

        private void 历史日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyLog();
        }

        public void OutputMessageReceived(string msg, int i)
        {
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(_upd, msg, i);
            }
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                ListView1.Items.Clear();
                for (int i = 0; i < _outputItemList.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = _outputItemList[i].time;
                    item.SubItems.Add(_outputItemList[i].msg);
                    item.ForeColor = _outputItemList[i].color;
                    ListView1.Items.Add(item);
                    ListView1.EnsureVisible(ListView1.Items.Count - 1);
                }
            }));
        }

        private void BtnTip_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                ListView1.Items.Clear();
                for (int i = 0; i < _outputItemList.Count; i++)
                {
                    if (_outputItemList[i].colorIndex == OutputLevelModel.INFO)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = _outputItemList[i].time;
                        item.SubItems.Add(_outputItemList[i].msg);
                        item.ForeColor = _outputItemList[i].color;
                        ListView1.Items.Add(item);
                        ListView1.EnsureVisible(ListView1.Items.Count - 1);
                    }
                }
            }));
        }

        private void BtnWarn_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                ListView1.Items.Clear();
                for (int i = 0; i < _outputItemList.Count; i++)
                {
                    if (_outputItemList[i].colorIndex == OutputLevelModel.WARN)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = _outputItemList[i].time;
                        item.SubItems.Add(_outputItemList[i].msg);
                        item.ForeColor = _outputItemList[i].color;
                        ListView1.Items.Add(item);
                        ListView1.EnsureVisible(ListView1.Items.Count - 1);
                    }
                }
            }));
        }

        private void BtnError_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                ListView1.Items.Clear();
                for (int i = 0; i < _outputItemList.Count; i++)
                {
                    if (_outputItemList[i].colorIndex == OutputLevelModel.ERROR)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = _outputItemList[i].time;
                        item.SubItems.Add(_outputItemList[i].msg);
                        item.ForeColor = _outputItemList[i].color;
                        ListView1.Items.Add(item);
                        ListView1.EnsureVisible(ListView1.Items.Count - 1);
                    }
                }
            }));
        }
    }
    public struct OutputItem
    {
        public string msg;
        public string time;
        public Color color;
        public int colorIndex;
    }
}
