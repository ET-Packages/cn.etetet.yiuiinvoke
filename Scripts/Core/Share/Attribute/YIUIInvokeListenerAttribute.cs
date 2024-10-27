using System;

namespace ET
{
    //文档:https://lib9kmxvq7k.feishu.cn/wiki/TpyYwbWIUizhfKkcubocTZgInse
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class YIUIInvokeListenerAttribute : BaseAttribute
    {
        public string Type { get; }

        public YIUIInvokeListenerAttribute(string type)
        {
            this.Type = type;
        }
    }
}