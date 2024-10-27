using System;

namespace ET
{
    public partial class YIUIInvokeListenerSystem
    {
        public R InvokeListener<T, R>(T self, string attributeType)
                where T : Entity
        {
            try
            {
                var invoker = this.GetInvokeListener<IYIUIInvokeListenerReturnHandler<R>>(self, attributeType);
                if (invoker == null) return default;
                return invoker.InvokeListener(self);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }

            return default;
        }

        public R InvokeListener<T, T1, R>(T self, string attributeType, T1 arg1)
                where T : Entity
        {
            try
            {
                var invoker = this.GetInvokeListener<IYIUIInvokeListenerReturnHandler<T1, R>>(self, attributeType);
                if (invoker == null) return default;
                return invoker.InvokeListener(self, arg1);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }

            return default;
        }

        public R InvokeListener<T, T1, T2, R>(T self, string attributeType, T1 arg1, T2 arg2)
                where T : Entity
        {
            try
            {
                var invoker = this.GetInvokeListener<IYIUIInvokeListenerReturnHandler<T1, T2, R>>(self, attributeType);
                if (invoker == null) return default;
                return invoker.InvokeListener(self, arg1, arg2);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }

            return default;
        }

        public R InvokeListener<T, T1, T2, T3, R>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3)
                where T : Entity
        {
            try
            {
                var invoker = this.GetInvokeListener<IYIUIInvokeListenerReturnHandler<T1, T2, T3, R>>(self, attributeType);
                if (invoker == null) return default;
                return invoker.InvokeListener(self, arg1, arg2, arg3);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }

            return default;
        }

        public R InvokeListener<T, T1, T2, T3, T4, R>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
                where T : Entity
        {
            try
            {
                var invoker = this.GetInvokeListener<IYIUIInvokeListenerReturnHandler<T1, T2, T3, T4, R>>(self, attributeType);
                if (invoker == null) return default;
                return invoker.InvokeListener(self, arg1, arg2, arg3, arg4);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }

            return default;
        }

        public R InvokeListener<T, T1, T2, T3, T4, T5, R>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
                where T : Entity
        {
            try
            {
                var invoker = this.GetInvokeListener<IYIUIInvokeListenerReturnHandler<T1, T2, T3, T4, T5, R>>(self, attributeType);
                if (invoker == null) return default;
                return invoker.InvokeListener(self, arg1, arg2, arg3, arg4, arg5);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }

            return default;
        }
    }
}