namespace ET
{
    /// <summary>
    /// 特殊情况下使用的 提前检查一个InvokeEntity是否存在
    /// </summary>
    public static class EventSystem_Check_Invoke_Entity
    {
        public static bool CheckInvokeEntity<A>(this EventSystem self, long type) where A : struct
        {
            return self.GetInvoker<AInvokeEntityHandler<A>, A>(type) != null;
        }

        public static bool CheckInvokeEntity<A, T>(this EventSystem self, long type) where A : struct
        {
            return self.GetInvoker<AInvokeEntityHandler<A, T>, A>(type) != null;
        }

        public static bool CheckInvokeEntity<A>(this EventSystem self) where A : struct
        {
            return self.CheckInvokeEntity<A>(0);
        }

        public static bool CheckInvokeEntity<A, T>(this EventSystem self) where A : struct
        {
            return self.CheckInvokeEntity<A, T>(0);
        }
    }
}