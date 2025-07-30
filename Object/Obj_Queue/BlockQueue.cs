using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

/****************************************************************

*****************************************************************/
namespace Obj.Obj_Queue
{
    /// <summary>
    /// 阻塞队列
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BlockQueue<T>
    {
        private BlockingCollection<T> _blockQueue;
        private readonly int maxSize;


        public BlockQueue(int _maxSize)
        {
            maxSize = _maxSize;
            _blockQueue = new BlockingCollection<T>(maxSize);
        }

        ///<summary>
        ///往队列中添加数据
        /// </summary>
        public void Enqueue(T item)
        {
            _blockQueue.Add(item);
        }

        /// <summary>
        /// 默认100ms之内没有尝试加入到队列，则直接返回false,入队失败
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool TryEnqueue(T item, int millisecondsTimeout = 100)
        {
            return _blockQueue.TryAdd(item, millisecondsTimeout);
        }

        ///<summary>
        ///从队列中取数据(用于foreach)
        /// </summary>
        public IEnumerable<T> GetEnumerable()
        {
            return _blockQueue.GetConsumingEnumerable();
        }
        ///<summary>
        ///从队列中取数据
        /// </summary>
        public T Dequeue()
        {
            try
            {
                return _blockQueue.Take();
            }
            catch (InvalidOperationException)
            {
                return default(T);
            }
        }

        /// <summary>
        /// 默认100ms之内没有尝试取出元素，则直接返回false,出队失败
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool TryDequeue(out T item, int millisecondsTimeout = 1000)
        {
            item = default(T);
            return _blockQueue.TryTake(out item, millisecondsTimeout);
        }

        ///<summary>
        ///获取队列内部元素的数量
        /// </summary>
        public int GetQueueItemCount { get { return _blockQueue.Count; } }

        ///<summary>
        ///禁止队列添加数据
        /// </summary>
        public void CompleteAdding()
        {
            _blockQueue.CompleteAdding();
        }

        ///<summary>
        ///队列中的元素是否处理完，为空集,并且调用了CompleteAdding
        /// </summary>
        public bool IsCompleted
        {
            get
            {
                try
                {
                    return _blockQueue.IsCompleted;
                }
                catch
                {
                    return true;
                }
            }
        }

        public void Close()
        {
            _blockQueue.Dispose();
        }

    }
}
