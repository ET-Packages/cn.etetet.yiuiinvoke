using System;

namespace ET
{
    public interface IYIUIInvokeListenerHandler : ISystemType
    {
        void InvokeListener(Entity self);
    }

    public interface IYIUIInvokeListenerHandler<in P1> : ISystemType
    {
        void InvokeListener(Entity self, P1 p1);
    }

    public interface IYIUIInvokeListenerHandler<in P1, in P2> : ISystemType
    {
        void InvokeListener(Entity self, P1 p1, P2 p2);
    }

    public interface IYIUIInvokeListenerHandler<in P1, in P2, in P3> : ISystemType
    {
        void InvokeListener(Entity self, P1 p1, P2 p2, P3 p3);
    }

    public interface IYIUIInvokeListenerHandler<in P1, in P2, in P3, in P4> : ISystemType
    {
        void InvokeListener(Entity self, P1 p1, P2 p2, P3 p3, P4 p4);
    }

    public interface IYIUIInvokeListenerHandler<in P1, in P2, in P3, in P4, in P5> : ISystemType
    {
        void InvokeListener(Entity self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    }

    public abstract class YIUIInvokeListenerHandler<T> : SystemObject, IYIUIInvokeListenerHandler where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerHandler);
        }

        public void InvokeListener(Entity self)
        {
            InvokeListener((T)self);
        }

        protected abstract void InvokeListener(T self);
    }

    public abstract class YIUIInvokeListenerHandler<T, P1> : SystemObject, IYIUIInvokeListenerHandler<P1> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerHandler<P1>);
        }

        public void InvokeListener(Entity self, P1 p1)
        {
            InvokeListener((T)self, p1);
        }

        protected abstract void InvokeListener(T self, P1 p1);
    }

    public abstract class YIUIInvokeListenerHandler<T, P1, P2> : SystemObject, IYIUIInvokeListenerHandler<P1, P2> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerHandler<P1, P2>);
        }

        public void InvokeListener(Entity self, P1 p1, P2 p2)
        {
            InvokeListener((T)self, p1, p2);
        }

        protected abstract void InvokeListener(T self, P1 p1, P2 p2);
    }

    public abstract class YIUIInvokeListenerHandler<T, P1, P2, P3> : SystemObject, IYIUIInvokeListenerHandler<P1, P2, P3> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerHandler<P1, P2, P3>);
        }

        public void InvokeListener(Entity self, P1 p1, P2 p2, P3 p3)
        {
            InvokeListener((T)self, p1, p2, p3);
        }

        protected abstract void InvokeListener(T self, P1 p1, P2 p2, P3 p3);
    }

    public abstract class YIUIInvokeListenerHandler<T, P1, P2, P3, P4> : SystemObject, IYIUIInvokeListenerHandler<P1, P2, P3, P4> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerHandler<P1, P2, P3, P4>);
        }

        public void InvokeListener(Entity self, P1 p1, P2 p2, P3 p3, P4 p4)
        {
            InvokeListener((T)self, p1, p2, p3, p4);
        }

        protected abstract void InvokeListener(T self, P1 p1, P2 p2, P3 p3, P4 p4);
    }

    public abstract class YIUIInvokeListenerHandler<T, P1, P2, P3, P4, P5> : SystemObject, IYIUIInvokeListenerHandler<P1, P2, P3, P4, P5> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeListenerHandler<P1, P2, P3, P4, P5>);
        }

        public void InvokeListener(Entity self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            InvokeListener((T)self, p1, p2, p3, p4, p5);
        }

        protected abstract void InvokeListener(T self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    }
}
