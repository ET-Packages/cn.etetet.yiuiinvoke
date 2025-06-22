using System;

namespace ET
{
    /// <summary>
    /// InvokeEntity事件
    /// </summary>
    public static class YIUIEventSystem
    {
        public static void InvokeEntity<A>(this EventSystem self, Entity entity, long type, A args) where A : struct
        {
            var aInvokeHandler = self.GetInvoker<AInvokeEntityHandler<A>, A>(type);
            if (aInvokeHandler == null)
            {
                throw new Exception($"Invoke error3, not AInvokeHandler: {type} {typeof(A).FullName}");
            }

            aInvokeHandler.Handle(entity, args);
        }

        public static T InvokeEntity<A, T>(this EventSystem self, Entity entity, long type, A args) where A : struct
        {
            var aInvokeHandler = self.GetInvoker<AInvokeEntityHandler<A, T>, A>(type);
            if (aInvokeHandler == null)
            {
                throw new Exception($"Invoke error6, not AInvokeHandler: {type} {typeof(A).FullName} {typeof(T).FullName} ");
            }

            return aInvokeHandler.Handle(entity, args);
        }

        public static void InvokeEntity<A>(this EventSystem self, Entity entity, A args) where A : struct
        {
            self.InvokeEntity(entity, 0, args);
        }

        public static T InvokeEntity<A, T>(this EventSystem self, Entity entity, A args) where A : struct
        {
            return self.InvokeEntity<A, T>(entity, 0, args);
        }
    }
}