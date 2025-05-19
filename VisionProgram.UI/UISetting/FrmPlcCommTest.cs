using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass.PLC;
using VisionProgram.Main.ProjectClass;

/****************************************************************

*****************************************************************/
namespace VisionProgram.UI.UISetting
{
    public partial class FrmPlcCommTest : Form
    {
        private List<PLCSignalInfo> _unCheckSignalInfoList = new List<PLCSignalInfo>();//中间信号变量表1 存储没有被选中的信号变量
        private List<PLCSignalInfo> _checkedSignalInfoList = new List<PLCSignalInfo>();//存储选中的信号变量表
        private List<int> _numList = new List<int>();//记录被选中的行

        private Color _redColor = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
        private Color _greenColor = Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));

        internal bool IsFormOpen = false;

        private FrmPlcCommTest()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    //避免闪屏
                return cp;
            }
        }

        /// 窗体对象实例
        /// </summary>
        private static FrmPlcCommTest _instance;
        public static FrmPlcCommTest Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmPlcCommTest();
                return _instance;
            }
        }

        private void FrmPlcCommTest_Load(object sender, EventArgs e)
        {
            IsFormOpen = true;
            //加载plc的ip 
            InitCbPlcIp();
        }

        private void InitCbPlcIp()
        {
            ComboBoxEXIP.Items.Clear();
            for (int i = 0; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
            {
                ComboBoxEXIP.Items.Add(Project.Instance().PLCManagerInstance.L_PLCInfo[i].IP);
            }
            //IP默认选中第一条
            this.ComboBoxEXIP.OnSelectedIndexChanged -= new System.EventHandler(this.CbPlcIp_SelectedIndexChanged);
            ComboBoxEXIP.SelectedIndex = 0;
            TextBoxPort.Text = Project.Instance().PLCManagerInstance.L_PLCInfo[ComboBoxEXIP.SelectedIndex].Port;
            //LabelPlcStatus.Text = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].PLCConnectState ? "已连接" : "未连接";
            //LabelPlcStatus.ForeColor = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].PLCConnectState ? _greenColor : _redColor;
            ClearData();
            _numList.Clear();
            _unCheckSignalInfoList.AddRange(Project.Instance().PLCManagerInstance.L_PLCSignalInfoList[ComboBoxEXIP.SelectedIndex]);
            UpdateUIListView1();
            this.ComboBoxEXIP.OnSelectedIndexChanged += new System.EventHandler(this.CbPlcIp_SelectedIndexChanged);
        }

        /// <summary>
        /// 初始化以及切换PLC时重置某些数据状态
        /// </summary>
        private void ClearData()
        {
            //清空所有信号
            this._unCheckSignalInfoList.Clear();
            this._checkedSignalInfoList.Clear();
            this.ListView1.Clear();
            this.ListView2.Clear();
            this.ButtonUp.Enabled = false;
            this.ButtonDown.Enabled = false;
        }

        private void CbPlcIp_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectIndex = ComboBoxEXIP.SelectedIndex;
            TextBoxPort.Text = Project.Instance().PLCManagerInstance.L_PLCInfo[selectIndex].Port;
            //LabelPlcStatus.Text = Project.Instance().PLCManagerInstance.L_basePLCObjects[selectIndex].PLCConnectState ? "已连接" : "未连接";
            //LabelPlcStatus.ForeColor = Project.Instance().PLCManagerInstance.L_basePLCObjects[selectIndex].PLCConnectState ? _greenColor : _redColor;
            ClearData();
            _numList.Clear();
            _unCheckSignalInfoList.AddRange(Project.Instance().PLCManagerInstance.L_PLCSignalInfoList[selectIndex]);
            UpdateUIListView1();
        }


        private void UpdateUIListView1()
        {
            ListView1.Clear();
            if (_unCheckSignalInfoList.Count <= 0) return;
            _unCheckSignalInfoList.Sort((item1, item2) => { return item1.Num > item2.Num ? 1 : -1; });
            ListView1.Columns.Add("序号", 50, HorizontalAlignment.Center);
            ListView1.Columns.Add("变量名", 330, HorizontalAlignment.Center);
            ListView1.Columns.Add("类型", 80, HorizontalAlignment.Center);
            ListView1.Columns.Add("备注", 150, HorizontalAlignment.Center);
            this.ListView1.BeginUpdate();
            for (int i = 0; i < _unCheckSignalInfoList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = _unCheckSignalInfoList[i].Num.ToString();
                item.SubItems.Add(_unCheckSignalInfoList[i].Name);
                item.SubItems.Add(_unCheckSignalInfoList[i].Type);
                item.SubItems.Add(_unCheckSignalInfoList[i].Msg);
                ListView1.Items.Add(item);
            }
            ListView1.EndUpdate();
        }

        private void UpdateUIListView2()
        {
            ListView2.Clear();
            if (_checkedSignalInfoList.Count <= 0) return;
            _checkedSignalInfoList.Sort((item1, item2) => { return item1.Num > item2.Num ? 1 : -1; });
            ListView2.Columns.Add("序号", 50, HorizontalAlignment.Center);
            ListView2.Columns.Add("变量名", 330, HorizontalAlignment.Center);
            ListView2.Columns.Add("类型", 80, HorizontalAlignment.Center);
            ListView2.Columns.Add("备注", 150, HorizontalAlignment.Center);
            this.ListView2.BeginUpdate();
            for (int i = 0; i < _checkedSignalInfoList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = _checkedSignalInfoList[i].Num.ToString();
                item.SubItems.Add(_checkedSignalInfoList[i].Name);
                item.SubItems.Add(_checkedSignalInfoList[i].Type);
                item.SubItems.Add(_checkedSignalInfoList[i].Msg);
                ListView2.Items.Add(item);
            }
            ListView2.EndUpdate();
        }


        private void listView1_Click(object sender, EventArgs e)
        {
            if (!ButtonDown.Enabled)
                ButtonDown.Enabled = true;
            if (ButtonUp.Enabled)
                ButtonUp.Enabled = false;

            _numList.Clear();
            //当某行信号变量被选中时，记录序号
            if (ListView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in ListView1.SelectedItems)
                {
                    _numList.Add(Convert.ToInt32(item.Text));
                }
            }
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            //将选中的行 加载到listView2中
            for (int i = 0; i < _numList.Count; i++)
            {
                var item = Project.Instance().PLCManagerInstance.L_PLCSignalInfoList[ComboBoxEXIP.SelectedIndex].Find(items => items.Num == _numList[i] && !string.IsNullOrEmpty(items.Name));
                _unCheckSignalInfoList.Remove(item);//去除被选中的项
                _checkedSignalInfoList.Add(item);
            }
            _numList.Clear();
            UpdateUIListView1();
            UpdateUIListView2();
        }

        private void BtnUpAll_Click(object sender, EventArgs e)
        {
            //将所有 选中项返回到 未选信号表中
            if (_checkedSignalInfoList.Count <= 0) return;
            _unCheckSignalInfoList.AddRange(_checkedSignalInfoList);
            ListView2.Clear();
            this._checkedSignalInfoList.Clear();
            UpdateUIListView1();
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            //将选中的项返回到未选项
            for (int i = 0; i < _numList.Count; i++)
            {
                var item = _checkedSignalInfoList.Find(items => items.Num == _numList[i] && !string.IsNullOrEmpty(items.Name));
                _unCheckSignalInfoList.Add(item);
                _checkedSignalInfoList.Remove(item);
            }
            _numList.Clear();
            UpdateUIListView1();
            UpdateUIListView2();
        }

        private void listView2_Click(object sender, EventArgs e)
        {
            if (ButtonDown.Enabled)
                ButtonDown.Enabled = false;
            if (!ButtonUp.Enabled)
                ButtonUp.Enabled = true;

            _numList.Clear();
            //当某行信号变量被选中时，记录序号
            if (ListView2.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in ListView2.SelectedItems)
                {
                    _numList.Add(Convert.ToInt32(item.Text));
                }
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            //读取信号
            if (_checkedSignalInfoList == null || _checkedSignalInfoList.Count <= 0)
            {
                this.ConfirmErrorDialog("请选择需要读取的标签！");
                return;
            }
            this.TextBoxEXText.Clear();
            string[] signals = new string[_checkedSignalInfoList.Count];
            for (int i = 0; i < _checkedSignalInfoList.Count; i++)
            {
                signals[i] = _checkedSignalInfoList[i].Name;
            }
            object[] objVale = new object[signals.Length];
            //bool successFlag = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].ReadMultiTagValue(signals, out objVale);
            string result = "";
            if (objVale == null)
            {
                this.TextBoxEXText.Text = "NULL";
                ShowMsg($"标签【{string.Join(",", signals)}】读取失败！", _redColor);
            }
            else
            {
                for (int i = 0; i < objVale.Length; i++)
                {
                    if (objVale[i] == null)
                        objVale[i] = "NULL";
                    result += objVale[i].ToString() + "；";
                }
                this.TextBoxEXText.Text = result;
                // ShowMsg($"标签【{string.Join(",", signals)}】" + (successFlag ? "读取成功！" : "读取失败！"), successFlag ? Color.Black : _redColor);
            }
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            if (_checkedSignalInfoList == null || _checkedSignalInfoList.Count <= 0)
            {
                this.ConfirmErrorDialog("请选择需要写入的标签！");
                return;
            }
            if (_checkedSignalInfoList.Count > 1)
            {
                this.ConfirmErrorDialog("只能选择一个标签进行写入！");
                return;
            }

            if (string.IsNullOrEmpty(this.TextBoxEXText.Text) || string.IsNullOrWhiteSpace(this.TextBoxEXText.Text))
            {
                this.ConfirmErrorDialog("请输入需要写入标签的值！");
                return;
            }

            try
            {
                string data = this.TextBoxEXText.Text.Trim();
                bool successFlag = false;
                switch (_checkedSignalInfoList[0].Type)
                {
                    //case "int":
                    //    successFlag = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].Write(_checkedSignalInfoList[0].Name, Convert.ToInt32(data));
                    //    break;
                    //case "double":
                    //    successFlag = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].Write(_checkedSignalInfoList[0].Name, Convert.ToDouble(data));
                    //    break;
                    //case "string":
                    //    successFlag = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].Write(_checkedSignalInfoList[0].Name, data);
                    //    break;
                    //case "bool":
                    //    successFlag = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].Write(_checkedSignalInfoList[0].Name, Convert.ToBoolean(data));
                    //    break;
                    //case "float":
                    //    successFlag = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].Write(_checkedSignalInfoList[0].Name, Convert.ToSingle(data));
                    //    break;
                    //default:
                    //    successFlag = Project.Instance().PLCManagerInstance.L_basePLCObjects[ComboBoxEXIP.SelectedIndex].Write(_checkedSignalInfoList[0].Name, data);
                    //    break;
                }
                ShowMsg($"标签【{_checkedSignalInfoList[0].Name}】" + (successFlag ? "写入成功！" : "写入失败！"), successFlag ? Color.Black : _redColor);
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message, _redColor);
            }

        }

        /// <summary>
        /// 信息显示
        /// </summary>
        /// <param name="message">要显示的信息</param>
        private void ShowMsg(string message, Color color)
        {
            try
            {
                this.RichTextBoxRecord.SelectionStart = this.RichTextBoxRecord.Text.Length;
                this.RichTextBoxRecord.SelectionColor = Color.Black;
                string curTime = DateTime.Now.ToString("HH:mm:ss");
                this.RichTextBoxRecord.AppendText(curTime);
                this.RichTextBoxRecord.SelectionStart = this.RichTextBoxRecord.Text.Length;
                this.RichTextBoxRecord.SelectionColor = color;
                this.RichTextBoxRecord.AppendText(" " + message + "\r\n");
                this.RichTextBoxRecord.ScrollToCaret();
                Application.DoEvents();
            }
            catch
            {

            }
        }

        private void 清空记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RichTextBoxRecord.Clear();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            IsFormOpen = false;
            this.Close();
        }

        #region 拖动窗体
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        #endregion
    }
}
