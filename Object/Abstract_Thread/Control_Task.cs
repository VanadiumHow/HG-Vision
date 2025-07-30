using System;
using System.Threading;
using System.Threading.Tasks;

/****************************************************************

*****************************************************************/
namespace BaseThread
{
    public abstract class Control_Task : BaseClass, IDisposable
    {
        private CancellationTokenSource _cts;
        private Task _task;
        private int _delayTime;
        private string _threadName = "";
        private bool _isRunning = false;

        private readonly object _syncLock = new object();

        protected override bool Start(int delayTime, string threadName = "")
        {
            lock (_syncLock)
            {
                if (_isRunning) return false;
                _delayTime = delayTime;
                _threadName = threadName;
                _cts = new CancellationTokenSource();
                _task = Task.Run(() => ThreadLoop(_cts.Token), _cts.Token);
                _isRunning = true;
                return true;
            }
        }

        protected override void Stop()
        {
            if (!_isRunning) return;
            _cts.Cancel();
            try
            {
                _task.Wait(1000);
            }
            catch (AggregateException) { }
            finally
            {
                _cts.Dispose();
                _isRunning = false;
            }
        }
        public void Dispose()
        {
            Stop();
        }

        private async Task ThreadLoop(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    Run(); // 子类实现
                    await Task.Delay(_delayTime, token).ConfigureAwait(false);
                }
            }
            catch { }
        }
    }
}