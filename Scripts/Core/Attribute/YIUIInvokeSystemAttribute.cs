namespace ET
{
    public class YIUIInvokeSystemAttribute : BaseAttribute
    {
        public string Type { get; }

        public YIUIInvokeSystemAttribute(string type)
        {
            this.Type = type;
        }
    }
}