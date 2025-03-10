using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Models.VModels;
using VisionProgram.UserControls.UIRadioButton;
using VisionProgram.UserControls.UITextBox;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Common
{
    /// <summary>
    /// 其他工具方法
    /// </summary>
    public static class Utility
    {


        /// <summary>
        /// 可执行委托的try  catch 异常处理
        /// </summary>
        /// <param name="act"></param>
        /// <param name="message"></param>
        public static bool TryCatch(this Action act, string message)
        {
            try
            {
                act.Invoke();
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error(message, ex);
                return false;
            }
        }

        /// <summary>
        /// 判断是否为IP地址
        /// </summary>
        /// <param name="ipStr"></param>
        /// <returns></returns>
        public static bool isIp(this string ipStr)
        {
            IPAddress ip;
            return IPAddress.TryParse(ipStr, out ip);
        }

        /// <summary>
        /// 日期转中文
        /// </summary>
        /// <param name="week"></param>
        /// <returns></returns>
        public static string getWeek(this string week)
        {
            string w = "";
            switch (week)
            {
                case "Monday":
                    w = "星期一";
                    break;
                case "Tuesday":
                    w = "星期二";
                    break;
                case "Wednesday":
                    w = "星期三";
                    break;
                case "Thursday":
                    w = "星期四";
                    break;
                case "Friday":
                    w = "星期五";
                    break;
                case "Saturday":
                    w = "星期六";
                    break;
                case "Sunday":
                    w = "星期天";
                    break;
                default:
                    break;
            }
            return w;
        }


        /// <summary>
        /// 判断是否数字
        /// </summary>
        /// <returns></returns>
        public static bool isNumberic(this string intStr)
        {
            int i;
            return int.TryParse(intStr, out i);
        }

        delegate void DelSetControlsText(Control parent, Control[] controls, List<string> values, string tag);
        /// <summary>
        /// 批量渲染显示控件
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="controls"></param>
        /// <param name="values"></param>
        /// <param name="tag"></param>
        public static void SetControlsText(Control parent, Control[] controls, List<string> values, string tag)
        {
            try
            {
                if (parent == null || controls == null)
                    return;

                if (parent.InvokeRequired)
                    parent.BeginInvoke((DelSetControlsText)SetControlsText, parent, controls, values, tag);
                else
                {
                    for (int i = 0; i < controls.Length && i < values.Count; i++)
                    {
                        if (controls[i] is TextBox)
                        {
                            controls[i].Text = values[i] ?? "";
                        }
                        else if (controls[i] is TextBoxEX)
                        {
                            ((TextBoxEX)controls[i]).Text = values[i] ?? "";
                        }
                        else if (controls[i] is Label)
                        {
                            controls[i].Text = values[i] ?? "";
                        }
                        else if (controls[i] is RadioButton)
                        {
                            ((RadioButton)controls[i]).Checked = bool.Parse(values[i]);
                        }
                        else if (controls[i] is RadioButtonEX)
                        {
                            ((RadioButtonEX)controls[i]).Checked = bool.Parse(values[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"加载{tag}出现异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Error($"加载{tag}出现异常", ex);
            }
        }
    }
}
