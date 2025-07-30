using System;
using System.Threading;
using System.Windows.Forms;
using Model.ConstantModel;
#region using Visionprogram::namespace
using HG_Vision.UIHome;
using HG_Vision.Manager.Manager_System;
#endregion
namespace HG_Vision
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool createdNew; //返回是否赋予了使用线程的互斥体初始所属权
            System.Threading.Mutex instance = new System.Threading.Mutex(true, "VisionProgram", out createdNew); 
            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
                MyShowSplashScreen();
                Application.Run(FrmHome.Instance);
                ProgramGerneral.FrmSplashScreen.CloseForm();
            }
            else
            {
                MessageBox.Show("该视觉程序已经在运行中（或之前视觉程序尚未完全关闭）!");
                Thread.Sleep(1000);
                Environment.Exit(0);
                return;
            }
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // UI thread exception.
            var msg = e.Exception.ToString();
            var ss = string.Format("{0}发生UI线程异常。\r\n{1}\r\n\r\n\r\n", DateTime.Now, msg);
            System.IO.File.AppendAllText(FilePathModel.SystemLogPath, ss);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // unknown exception.
            var msg = e.ExceptionObject.ToString();
            var ss = string.Format("{0}发生非UI系统异常。\r\n{1}\r\n\r\n\r\n", DateTime.Now, msg);
            System.IO.File.AppendAllText(FilePathModel.SystemLogPath, ss);
        }


        static void MyShowSplashScreen()
        {
            ProgramGerneral.FrmSplashScreen.ShowSplashScreen("焊接程序");
            Application.DoEvents();
            //实例化Project并且实例化管理类
            Project.Instance.InitialManagerObj();
            ProgramGerneral.FrmSplashScreen.SetStatus("加载系统设置参数...");       
            Project.Instance.LoadGlobalConfig();
            ProgramGerneral.FrmSplashScreen.SetStatus("加载用户信息...");
            Project.Instance.LoadUserInfo();
            ProgramGerneral.FrmSplashScreen.SetStatus("加载视觉功能块...");
            Project.Instance.LoadVisionInfo();
            ProgramGerneral.FrmSplashScreen.SetStatus("初始化PLC...");
            Project.Instance.InitialPLC();
            Project.Instance.InitialProductionData();
            ProgramGerneral.FrmSplashScreen.SetStatus("初始Robot/Laser服务器...");
            Project.Instance.InitialRobotSever();
            ProgramGerneral.FrmSplashScreen.SetStatus("初始Laser客户端...");
            Project.Instance.InitialLaserClient();
            ProgramGerneral.FrmSplashScreen.SetStatus("初始化硬件状态...");
            Project.Instance.InitialHardWareState();
            ProgramGerneral.FrmSplashScreen.SetStatus("窗体加载中...");
            Thread.Sleep(200);
        }

    }
}
