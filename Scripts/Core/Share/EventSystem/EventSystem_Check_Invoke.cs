namespace ET
{
    /// <summary>
    /// 特殊情况下使用的 提前检查一个Invoke是否存在
    /// </summary>
    public static class EventSystemCheck_Invoke
    {
        public static bool CheckInvoke<A>(this EventSystem self, long type) where A : struct
        {
            return self.GetInvoker<AInvokeHandler<A>, A>(type) != null;
        }

        public static bool CheckInvoke<A, T>(this EventSystem self, long type) where A : struct
        {
            return self.GetInvoker<AInvokeHandler<A, T>, A>(type) != null;
        }

        public static bool CheckInvoke<A>(this EventSystem self) where A : struct
        {
            return self.CheckInvoke<A>(0);
        }

        public static bool CheckInvoke<A, T>(this EventSystem self) where A : struct
        {
            return self.CheckInvoke<A, T>(0);
        }
    }
}