using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using VisionProgram.UserControls.UIRadioButton;
using VisionProgram.UserControls.UITextBox;

/****************************************************************

*****************************************************************/
namespace Obj.Utility
{
    /// <summary>
    /// 其他工具方法
    /// </summary>
    public class MyEventArgs : EventArgs
    {
        public object obj;
        public MyEventArgs(object obj1)
        {
            obj = obj1;
        }
    }
    public static class CommonUtility
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
        /// UI控件值批量设置
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
                        Type controlType = controls[i].GetType();
                        if (_handlers.TryGetValue(controlType, out var handler))
                        {
                            handler(controls[i], values[i]); // 调用匹配的处理器
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
        private static readonly Dictionary<Type, Action<Control, string>> _handlers =
new Dictionary<Type, Action<Control, string>>
{
    // 基础控件
[typeof(TextBox)] = (c, v) => ((TextBox)c).Text = v ?? "",
[typeof(Label)] = (c, v) => ((Label)c).Text = v ?? "",
[typeof(RadioButton)] = (c, v) =>
    ((RadioButton)c).Checked = bool.TryParse(v, out bool b) && b,

    // 扩展控件（如自定义 TextBoxEX / RadioButtonEX）
[typeof(TextBoxEX)] = (c, v) => ((TextBoxEX)c).Text = v ?? "",
[typeof(RadioButtonEX)] = (c, v) =>
    ((RadioButtonEX)c).Checked = bool.TryParse(v, out bool b) && b
};
    }
}
