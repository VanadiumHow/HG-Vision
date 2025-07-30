using ProgramGerneral;
using System;
using BaseThread;
using System.Windows.Forms;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Thread
{
    internal class FrmSplashScreenThread : Control_Thread
    {
        public override void Initialize()
        {
            this.Start(-1, "FrmSplashScreenThread");
        }
        public override void Deinitialize()
        {
            this.Stop();
        }
        protected override void Run()
        {
            FrmSplashScreen.ms_frmSplash = new FrmSplashScreen();
            Application.Run(FrmSplashScreen.ms_frmSplash);
        }
    }
}
