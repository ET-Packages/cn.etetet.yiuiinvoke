using System;

namespace ET
{
    public partial class YIUIInvokeListenerSystem
    {
        public void InvokeListener<T>(T self, string attributeType)
                where T : Entity
        {
            try
            {
                this.GetInvokeListener<IYIUIInvokeListenerHandler>(self, attributeType)?.InvokeListener(self);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void InvokeListener<T, T1>(T self, string attributeType, T1 arg1)
                where T : Entity
        {
            try
            {
                this.GetInvokeListener<IYIUIInvokeListenerHandler<T1>>(self, attributeType)?.InvokeListener(self, arg1);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void InvokeListener<T, T1, T2>(T self, string attributeType, T1 arg1, T2 arg2)
                where T : Entity
        {
            try
            {
                this.GetInvokeListener<IYIUIInvokeListenerHandler<T1, T2>>(self, attributeType)?.InvokeListener(self, arg1, arg2);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void InvokeListener<T, T1, T2, T3>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3)
                where T : Entity
        {
            try
            {
                this.GetInvokeListener<IYIUIInvokeListenerHandler<T1, T2, T3>>(self, attributeType)?.InvokeListener(self, arg1, arg2, arg3);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void InvokeListener<T, T1, T2, T3, T4>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
                where T : Entity
        {
            try
            {
                this.GetInvokeListener<IYIUIInvokeListenerHandler<T1, T2, T3, T4>>(self, attributeType)?.InvokeListener(self, arg1, arg2, arg3, arg4);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }

        public void InvokeListener<T, T1, T2, T3, T4, T5>(T self, string attributeType, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
                where T : Entity
        {
            try
            {
                this.GetInvokeListener<IYIUIInvokeListenerHandler<T1, T2, T3, T4, T5>>(self, attributeType)?.InvokeListener(self, arg1, arg2, arg3, arg4, arg5);
            }
            catch (Exception e)
            {
                Log.Error($"YIUIInvokeListener执行错误请检查{self.GetType().Name} >> {attributeType} 类型:{typeof(T).Name} {e.Message}");
            }
        }
    }
}