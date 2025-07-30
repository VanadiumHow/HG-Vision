namespace BaseThread
{
    /// <summary>
    /// 相机工作线程接口，强制实现初始化和反初始化方法
    /// </summary>
    public interface IBaseThread
    {
        void Initialize();
        void Deinitialize();
    }
    public abstract class BaseClass
    {
        protected abstract bool Start(int nDelayTime, string strName = "");
        protected abstract void Stop();
        protected abstract void Run();
    }
}
