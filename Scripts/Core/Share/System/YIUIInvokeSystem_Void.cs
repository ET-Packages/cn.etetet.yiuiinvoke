using System;

namespace ET
{
    public partial class YIUIInvokeSystem
    {
        public void Invoke<T>(T self, string attributeType)
                where T : Entity
        {
            try
            {
                var invoker = GetInvoker<IYIUIInvokeHandler>(attributeType);
                if (invoker == null) return;

                using var list = ListComponent<IYIUIInvokeHandler>.Create();
                YIUIListenerInvokeSystem.Instance.GetListenerInvokerBefore(attributeType, list);

                foreach (var listener in list)
                {
                    listener.Invoke(self);
                }

                invoker.Invoke(self);

                YIUIListenerInvokeSystem.Instance.GetListenerInvokerAfter(attributeType, list);
                foreach (var listener in list)
                {
                    listener.Invoke(self);
                }
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvoke执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void Invoke<T, T1>(T self, string attributeType, T1 arg1)
                where T : Entity
        {
            try
            {
                var invoker = GetInvoker<IYIUIInvokeHandler<T1>>(attributeType);
                if (invoker == null) return;

                using var list = ListComponent<IYIUIInvokeHandler<T1>>.Create();
                YIUIListenerInvokeSystem.Instance.GetListenerInvokerBefore(attributeType, list);

                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1);
                }

                invoker.Invoke(self, arg1);

                YIUIListenerInvokeSystem.Instance.GetListenerInvokerAfter(attributeType, list);
                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1);
                }
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvoke执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void Invoke<T, T1, T2>(T self, string attributeType, T1 arg1, T2 arg2)
                where T : Entity
        {
            try
            {
                var invoker = GetInvoker<IYIUIInvokeHandler<T1, T2>>(attributeType);
                if (invoker == null) return;

                using var list = ListComponent<IYIUIInvokeHandler<T1, T2>>.Create();
                YIUIListenerInvokeSystem.Instance.GetListenerInvokerBefore(attributeType, list);

                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1, arg2);
                }

                invoker.Invoke(self, arg1, arg2);

                YIUIListenerInvokeSystem.Instance.GetListenerInvokerAfter(attributeType, list);
                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1, arg2);
                }
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvoke执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void Invoke<T, T1, T2, T3>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3)
                where T : Entity
        {
            try
            {
                var invoker = GetInvoker<IYIUIInvokeHandler<T1, T2, T3>>(attributeType);
                if (invoker == null) return;

                using var list = ListComponent<IYIUIInvokeHandler<T1, T2, T3>>.Create();
                YIUIListenerInvokeSystem.Instance.GetListenerInvokerBefore(attributeType, list);

                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1, arg2, arg3);
                }

                invoker.Invoke(self, arg1, arg2, arg3);

                YIUIListenerInvokeSystem.Instance.GetListenerInvokerAfter(attributeType, list);
                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1, arg2, arg3);
                }
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvoke执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void Invoke<T, T1, T2, T3, T4>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
                where T : Entity
        {
            try
            {
                var invoker = GetInvoker<IYIUIInvokeHandler<T1, T2, T3, T4>>(attributeType);
                if (invoker == null) return;

                using var list = ListComponent<IYIUIInvokeHandler<T1, T2, T3, T4>>.Create();
                YIUIListenerInvokeSystem.Instance.GetListenerInvokerBefore(attributeType, list);

                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1, arg2, arg3, arg4);
                }

                invoker.Invoke(self, arg1, arg2, arg3, arg4);

                YIUIListenerInvokeSystem.Instance.GetListenerInvokerAfter(attributeType, list);
                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1, arg2, arg3, arg4);
                }
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvoke执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void Invoke<T, T1, T2, T3, T4, T5>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
                where T : Entity
        {
            try
            {
                var invoker = GetInvoker<IYIUIInvokeHandler<T1, T2, T3, T4, T5>>(attributeType);
                if (invoker == null) return;

                using var list = ListComponent<IYIUIInvokeHandler<T1, T2, T3, T4, T5>>.Create();
                YIUIListenerInvokeSystem.Instance.GetListenerInvokerBefore(attributeType, list);

                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1, arg2, arg3, arg4, arg5);
                }

                invoker.Invoke(self, arg1, arg2, arg3, arg4, arg5);

                YIUIListenerInvokeSystem.Instance.GetListenerInvokerAfter(attributeType, list);
                foreach (var listener in list)
                {
                    listener.Invoke(self, arg1, arg2, arg3, arg4, arg5);
                }
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvoke执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }
    }
}