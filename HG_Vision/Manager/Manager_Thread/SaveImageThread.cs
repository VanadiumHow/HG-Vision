using BaseThread;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using Model.ConstantModel;
using Obj.Obj_File;
using Obj.Obj_Image;
using Obj.Obj_Queue;
using System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Thread
{
    internal class SaveImageThread : Control_Thread
    {
        private BlockQueue<TriggerEventArgs> mSaveImageQueue;//相机触发队列集合
        internal BlockQueue<TriggerEventArgs> SaveImageQueue
        {
            private get { return mSaveImageQueue; }
            set { mSaveImageQueue = value; }
        }
        public override void Initialize()
        {
            this.Start(10, "SaveImageThread");
        }

        public override void Deinitialize()
        {
            this.Stop();
        }

        protected override void Run()
        {
            try
            {
                TriggerEventArgs e = null;
                if (mSaveImageQueue.TryDequeue(out e))
                {
                    ImageParamsModel _imageParams = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[e.FlowIdx];
                    ImageStoreHelper.SaveRawImage(e.rawImage, e.imageName, e.results, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH-mm-ss-fff"), e.FlowIdx, _imageParams);
                    ImageStoreHelper.SaveResultImage(e.DisplayObj, e.imageName, e.results, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH-mm-ss-fff"), e.FlowIdx, _imageParams);
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("存图线程异常", ex);
            }
        }
    }
}
