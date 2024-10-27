using System;
using System.Collections.Generic;
using System.Reflection;

namespace ET
{
    [CodeProcess]
    public partial class YIUIInvokeListenerSystem : Singleton<YIUIInvokeListenerSystem>, ISingletonAwake
    {
        private readonly Dictionary<Type, Dictionary<Type, Dictionary<string, object>>> m_AllInvokeListeners = new();

        public void Awake()
        {
            CodeTypes codeTypes = CodeTypes.Instance;

            foreach (Type type in codeTypes.GetTypes(typeof(YIUIInvokeListenerSystemAttribute)))
            {
                var obj = Activator.CreateInstance(type);
                if (obj is not ISystemType iSystemType)
                {
                    Log.Error($"必须实现ISystemType接口: {type.Name}");
                    continue;
                }

                var attribute = (YIUIInvokeListenerSystemAttribute)type.GetCustomAttribute(typeof(YIUIInvokeListenerSystemAttribute), true);

                var entityType    = iSystemType.Type();
                var systemType    = iSystemType.SystemType();
                var attributeType = attribute.Type;

                if (!m_AllInvokeListeners.TryGetValue(entityType, out var entityTypeDict))
                {
                    entityTypeDict = new();
                    m_AllInvokeListeners.Add(entityType, entityTypeDict);
                }

                if (!entityTypeDict.TryGetValue(systemType, out var systemTypeDict))
                {
                    systemTypeDict = new();
                    entityTypeDict.Add(systemType, systemTypeDict);
                }

                if (!systemTypeDict.TryAdd(attributeType, obj))
                {
                    Log.Error($"重复添加YIUIInvokeListener请检查{entityType.Name} >> {attributeType} \ntype:{type.Name} \nentityType:{entityType.Name} \nsystemType:{systemType.Name} \nattributeType:{attributeType}");
                }
            }
        }

        private T GetInvokeListener<T>(Entity self, string attributeType)
        {
            if (self == null)
            {
                Log.Error($"Entity 不能为null");
                return default;
            }

            if (m_AllInvokeListeners.TryGetValue(self.GetType(), out var entityTypeDict) && entityTypeDict.TryGetValue(typeof(T), out var systemTypeDict) && systemTypeDict.TryGetValue(attributeType, out var invoker))
            {
                if (invoker is T tInvokeListener)
                {
                    return tInvokeListener;
                }

                Log.Error($"找到YIUIInvokeListener实现请 但类型不一致请检查{self.GetType().Name} >> {attributeType}  需求:{typeof(T).Name} 实际:{invoker.GetType().Name}");
                return default;
            }

            Log.Error($"未找到YIUIInvokeListener实现请检查{self.GetType().Name} >> {attributeType}  类型:{typeof(T).Name}");
            return default;
        }
    }
}