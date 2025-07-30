using System.Windows.Forms;

/****************************************************************

*****************************************************************/
namespace Obj.Obj_Message
{
    public static class PopupBoxHelper
    {

        /// <summary>
        /// 弹出疑问类询问框
        /// </summary>
        /// <param name="f">this</param>
        /// <param name="message">文本</param>
        /// <param name="title">标题(选择性传入)</param>
        /// <returns></returns>
        ///       
        public static DialogResult QuestionInfoDialog(this Form f, string message, string title = "")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// 弹出警告类询问框
        /// </summary>
        /// <param name="f">this</param>
        /// <param name="message">文本</param>
        /// <param name="title">标题(选择性传入)</param>
        /// <returns></returns>
        public static DialogResult QuestionWarningDialog(this Form f, string message, string title = "")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 弹出信息类确认框
        /// </summary>
        /// <param name="f">this</param>
        /// <param name="message">文本</param>
        /// <param name="title">标题(选择性传入)</param>
        /// <returns></returns>
        public static DialogResult ConfirmInfoDialog(this Form f,string message, string title = "")
        {
           return MessageBox.Show(message, title, MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        ///  弹出警告类确认框
        /// </summary>
        /// <param name="f">this</param>
        /// <param name="message">文本</param>
        /// <param name="title">标题(选择性传入)</param>
        /// <returns></returns>
        public static DialogResult ConfirmWarningDialog(this Form f, string message, string title = "")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 弹出错误类确认框
        /// </summary>
        /// <param name="f">this</param>
        /// <param name="message">文本</param>
        /// <param name="title">标题(选择性传入)</param>
        /// <returns></returns>
        public static DialogResult ConfirmErrorDialog(this Form f, string message, string title = "")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
