﻿namespace ET
{
    //文档 https://lib9kmxvq7k.feishu.cn/wiki/XXzrwRGgti52s4kYdqFccswAnXe
    public class YIUIListenerInvokeSystemAttribute : BaseAttribute
    {
        public string Type     { get; }
        
        /// <summary>
        /// 执行优先级
        /// 小于0 则在Invoke之前执行
        /// 大于等于0 则在Invoke之后执行
        /// 同级越小的越先执行
        /// </summary>
        public int    Priority { get; }

        public YIUIListenerInvokeSystemAttribute(string type, int priority = 0)
        {
            this.Type     = type;
            this.Priority = priority;
        }
    }
}