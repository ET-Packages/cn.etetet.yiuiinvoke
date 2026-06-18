using System.Collections.Generic;
using System.Linq;

#if ET9
namespace ET
{
    /// <summary>
    /// 特殊情况下使用的 提前检查一个Invoke是否存在
    /// </summary>
    public partial class EventSystem
    {
        public Invoker GetInvoker<Invoker, A>(long type) where Invoker : class, IInvoke where A : struct
        {
            if (!this.allInvokers.TryGetValue(typeof(A), out Dictionary<long, object> invokeHandlers))
            {
                return null;
            }

            if (!invokeHandlers.TryGetValue(type, out object invokeHandler))
            {
                return null;
            }

            if (invokeHandler is not Invoker aInvokeHandler)
            {
                return null;
            }

            return aInvokeHandler;
        }

        public List<long> GetAllInvokerTypes<A>() where A : struct
        {
            if (!this.allInvokers.TryGetValue(typeof(A), out Dictionary<long, object> invokeHandlers))
            {
                return new List<long>();
            }

            return invokeHandlers.Keys.ToList();
        }

        // Invoke跟Publish的区别(特别注意)
        // Invoke类似函数，必须有被调用方，否则异常，调用者跟被调用者属于同一模块，比如MoveComponent中的Timer计时器，调用跟被调用的代码均属于移动模块
        // 既然Invoke跟函数一样，那么为什么不使用函数呢? 因为有时候不方便直接调用，比如Config加载，在客户端跟服务端加载方式不一样。比如TimerComponent需要根据Id分发
        // 注意，不要把Invoke当函数使用，这样会造成代码可读性降低，能用函数不要用Invoke
        // publish是事件，抛出去可以没人订阅，调用者跟被调用者属于两个模块，比如任务系统需要知道道具使用的信息，则订阅道具使用事件
        public void TryInvoke<A>(long type, A args) where A : struct
        {
            var aInvokeHandler = this.GetInvoker<AInvokeHandler<A>, A>(type);
            if (aInvokeHandler == null)
            {
                return;
            }

            aInvokeHandler.Handle(args);
        }

        public T TryInvoke<A, T>(long type, A args) where A : struct
        {
            var aInvokeHandler = this.GetInvoker<AInvokeHandler<A, T>, A>(type);
            if (aInvokeHandler == null)
            {
                return default;
            }

            return aInvokeHandler.Handle(args);
        }

        public void TryInvoke<A>(A args) where A : struct
        {
            TryInvoke(0, args);
        }

        public T TryInvoke<A, T>(A args) where A : struct
        {
            return TryInvoke<A, T>(0, args);
        }
    }
}
#endif