using System;

namespace ET
{
    public interface IYIUIInvokeHnadler : ISystemType
    {
        void Invoke(Entity self);
    }

    public interface IYIUIInvokeHnadler<in P1> : ISystemType
    {
        void Invoke(Entity self, P1 p1);
    }

    public interface IYIUIInvokeHnadler<in P1, in P2> : ISystemType
    {
        void Invoke(Entity self, P1 p1, P2 p2);
    }

    public interface IYIUIInvokeHnadler<in P1, in P2, in P3> : ISystemType
    {
        void Invoke(Entity self, P1 p1, P2 p2, P3 p3);
    }

    public interface IYIUIInvokeHnadler<in P1, in P2, in P3, in P4> : ISystemType
    {
        void Invoke(Entity self, P1 p1, P2 p2, P3 p3, P4 p4);
    }

    public interface IYIUIInvokeHnadler<in P1, in P2, in P3, in P4, in P5> : ISystemType
    {
        void Invoke(Entity self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    }

    public abstract class YIUIInvokeHandler<T> : SystemObject, IYIUIInvokeHnadler where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeHnadler);
        }

        public void Invoke(Entity self)
        {
            Invoke((T)self);
        }

        protected abstract void Invoke(T self);
    }

    public abstract class YIUIInvokeHandler<T, P1> : SystemObject, IYIUIInvokeHnadler<P1> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeHnadler<P1>);
        }

        public void Invoke(Entity self, P1 p1)
        {
            Invoke((T)self, p1);
        }

        protected abstract void Invoke(T self, P1 p1);
    }

    public abstract class YIUIInvokeHandler<T, P1, P2> : SystemObject, IYIUIInvokeHnadler<P1, P2> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeHnadler<P1, P2>);
        }

        public void Invoke(Entity self, P1 p1, P2 p2)
        {
            Invoke((T)self, p1, p2);
        }

        protected abstract void Invoke(T self, P1 p1, P2 p2);
    }

    public abstract class YIUIInvokeHandler<T, P1, P2, P3> : SystemObject, IYIUIInvokeHnadler<P1, P2, P3> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeHnadler<P1, P2, P3>);
        }

        public void Invoke(Entity self, P1 p1, P2 p2, P3 p3)
        {
            Invoke((T)self, p1, p2, p3);
        }

        protected abstract void Invoke(T self, P1 p1, P2 p2, P3 p3);
    }

    public abstract class YIUIInvokeHandler<T, P1, P2, P3, P4> : SystemObject, IYIUIInvokeHnadler<P1, P2, P3, P4> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeHnadler<P1, P2, P3, P4>);
        }

        public void Invoke(Entity self, P1 p1, P2 p2, P3 p3, P4 p4)
        {
            Invoke((T)self, p1, p2, p3, p4);
        }

        protected abstract void Invoke(T self, P1 p1, P2 p2, P3 p3, P4 p4);
    }

    public abstract class YIUIInvokeHandler<T, P1, P2, P3, P4, P5> : SystemObject, IYIUIInvokeHnadler<P1, P2, P3, P4, P5> where T : Entity
    {
        Type ISystemType.Type()
        {
            return typeof(T);
        }

        Type ISystemType.SystemType()
        {
            return typeof(IYIUIInvokeHnadler<P1, P2, P3, P4, P5>);
        }

        public void Invoke(Entity self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            Invoke((T)self, p1, p2, p3, p4, p5);
        }

        protected abstract void Invoke(T self, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5);
    }
}
