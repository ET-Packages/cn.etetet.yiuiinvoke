using System;
using System.Collections.Generic;
using System.Reflection;

namespace ET
{
    [CodeProcess]
    public partial class YIUIListenerInvokeSystem : Singleton<YIUIListenerInvokeSystem>, ISingletonAwake
    {
        private readonly Dictionary<string, List<(int, object)>> m_AllListenerInvokersBefore = new();
        private readonly Dictionary<string, List<(int, object)>> m_AllListenerInvokersAfter  = new();

        public void Awake()
        {
            CodeTypes codeTypes = CodeTypes.Instance;
            m_AllListenerInvokersBefore.Clear();
            m_AllListenerInvokersAfter.Clear();

            foreach (Type type in codeTypes.GetTypes(typeof(YIUIListenerInvokeSystemAttribute)))
            {
                var obj = Activator.CreateInstance(type);
                if (obj is not ISystemType iSystemType)
                {
                    Log.Error($"必须实现ISystemType接口: {type.Name}");
                    continue;
                }

                var attribute     = (YIUIListenerInvokeSystemAttribute)type.GetCustomAttribute(typeof(YIUIListenerInvokeSystemAttribute), true);
                var attributeType = attribute.Type;
                var priority      = attribute.Priority;

                if (priority >= 0)
                {
                    if (!m_AllListenerInvokersAfter.ContainsKey(attributeType))
                    {
                        m_AllListenerInvokersAfter.Add(attributeType, new());
                    }

                    var list = m_AllListenerInvokersAfter[attributeType];
                    list.Add((priority, obj));
                }
                else
                {
                    if (!m_AllListenerInvokersBefore.ContainsKey(attributeType))
                    {
                        m_AllListenerInvokersBefore.Add(attributeType, new());
                    }

                    var list = m_AllListenerInvokersBefore[attributeType];
                    list.Add((priority, obj));
                }
            }

            foreach (var key in m_AllListenerInvokersBefore.Keys)
            {
                var list = m_AllListenerInvokersBefore[key];
                SortListenerInvoker(list);
            }

            foreach (var key in m_AllListenerInvokersAfter.Keys)
            {
                var list = m_AllListenerInvokersAfter[key];
                SortListenerInvoker(list);
            }
        }

        private void SortListenerInvoker(List<(int, object)> invokers)
        {
            invokers.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        }

        public bool GetListenerInvokerBefore<T>(string attributeType, List<T> list)
        {
            list.Clear();
            GetListenerInvoker(m_AllListenerInvokersBefore, attributeType, list);
            return list.Count > 0;
        }

        public bool GetListenerInvokerAfter<T>(string attributeType, List<T> list)
        {
            list.Clear();
            GetListenerInvoker(m_AllListenerInvokersAfter, attributeType, list);
            return list.Count > 0;
        }

        private void GetListenerInvoker<T>(Dictionary<string, List<(int, object)>> all, string attributeType, List<T> list)
        {
            if (all.TryGetValue(attributeType, out var invokerList))
            {
                foreach (var invoke in invokerList)
                {
                    if (invoke.Item2 is T tListenerInvoker)
                    {
                        list.Add(tListenerInvoker);
                    }
                    else
                    {
                        Log.Error($"找到YIUIListenerInvoke实现请 但类型不一致请检查 {attributeType}  需求:{typeof(T).Name} 实际:{invoke.GetType().Name}");
                    }
                }
            }
        }
    }
}