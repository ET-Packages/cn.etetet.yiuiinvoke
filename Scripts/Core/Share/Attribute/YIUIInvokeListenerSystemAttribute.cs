namespace ET
{
    public class YIUIInvokeListenerSystemAttribute : BaseAttribute
    {
        public string Type { get; }

        public YIUIInvokeListenerSystemAttribute(string type)
        {
            this.Type = type;
        }
    }
}