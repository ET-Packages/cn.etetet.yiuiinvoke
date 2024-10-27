using System;

namespace ET
{
    public interface IYIUIInvokeListenerReturnHandler<out R> : ISystemType
    {
        R InvokeListener(Entity self);
    }

    public interface IYIUIInvokeListenerReturnHandler<in P1, out R> : ISystemType
    {
        R InvokeListener(Entity self, P1 p1);
    }

    public interface IYIUIInvokeListenerReturnHandler<in P1, in P2, out R> : ISystemType
    {
        R InvokeListener(Entity self, P1 p1, P2 p2);
    }

    public interface IYIUIInvokeListenerReturnHandler<in P1, in P2, in P3, out R> : ISystemType
    {
        R InvokeListener(Entity self, P1 p1, P2 p2, P3 p3);
    }

    public interface IYIUIInvokeListenerReturnHandler<in P1, in P2, in P3, in P4, out R> : ISystemType
    {
        R InvokeListener(Entity self, P1 p1, P2 p2, P3 p3, P4 p4);
    }

    public interface IYIUIInvokeListenerReturnHandler<in P1, in P2, in P3, in P4, in P5, out R> : ISystemType
    {
        R InvokeListener(Entity self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    }

    public abstract class YIUIInvokeListenerReturnHandler<T, R> : SystemObject, IYIUIInvokeListenerReturnHandler<R>
            where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerReturnHandler<R>);
        }

        public R InvokeListener(Entity self)
        {
            return InvokeListener((T)self);
        }

        protected abstract R InvokeListener(T self);
    }

    public abstract class YIUIInvokeListenerReturnHandler<T, P1, R> : SystemObject, IYIUIInvokeListenerReturnHandler<P1, R>
            where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerReturnHandler<P1, R>);
        }

        public R InvokeListener(Entity self, P1 p1)
        {
            return InvokeListener((T)self, p1);
        }

        protected abstract R InvokeListener(T self, P1 p1);
    }

    public abstract class YIUIInvokeListenerReturnHandler<T, P1, P2, R> : SystemObject, IYIUIInvokeListenerReturnHandler<P1, P2, R>
            where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerReturnHandler<P1, P2, R>);
        }

        public R InvokeListener(Entity self, P1 p1, P2 p2)
        {
            return InvokeListener((T)self, p1, p2);
        }

        protected abstract R InvokeListener(T self, P1 p1, P2 p2);
    }

    public abstract class YIUIInvokeListenerReturnHandler<T, P1, P2, P3, R> : SystemObject, IYIUIInvokeListenerReturnHandler<P1, P2, P3, R>
            where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerReturnHandler<P1, P2, P3, R>);
        }

        public R InvokeListener(Entity self, P1 p1, P2 p2, P3 p3)
        {
            return InvokeListener((T)self, p1, p2, p3);
        }

        protected abstract R InvokeListener(T self, P1 p1, P2 p2, P3 p3);
    }

    public abstract class YIUIInvokeListenerReturnHandler<T, P1, P2, P3, P4, R> : SystemObject, IYIUIInvokeListenerReturnHandler<P1, P2, P3, P4, R>
            where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerReturnHandler<P1, P2, P3, P4, R>);
        }

        public R InvokeListener(Entity self, P1 p1, P2 p2, P3 p3, P4 p4)
        {
            return InvokeListener((T)self, p1, p2, p3, p4);
        }

        protected abstract R InvokeListener(T self, P1 p1, P2 p2, P3 p3, P4 p4);
    }

    public abstract class YIUIInvokeListenerReturnHandler<T, P1, P2, P3, P4, P5, R> : SystemObject, IYIUIInvokeListenerReturnHandler<P1, P2, P3, P4, P5, R>
            where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerReturnHandler<P1, P2, P3, P4, P5, R>);
        }

        public R InvokeListener(Entity self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            return InvokeListener((T)self, p1, p2, p3, p4, p5);
        }

        protected abstract R InvokeListener(T self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    }
}