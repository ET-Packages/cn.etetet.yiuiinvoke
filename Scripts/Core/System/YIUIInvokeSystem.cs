using System;
using System.Collections.Generic;
using System.Reflection;

namespace ET
{
    [CodeProcess]
    public partial class YIUIInvokeSystem : Singleton<YIUIInvokeSystem>, ISingletonAwake
    {
        private readonly Dictionary<Type, Dictionary<Type, Dictionary<string, object>>> m_AllInvokers = new();

        public void Awake()
        {
            CodeTypes codeTypes = CodeTypes.Instance;

            foreach (Type type in codeTypes.GetTypes(typeof(YIUIInvokeSystemAttribute)))
            {
                var obj = Activator.CreateInstance(type);
                if (obj is not ISystemType iSystemType)
                {
                    Log.Error($"必须实现ISystemType接口: {type.Name}");
                    continue;
                }

                var attribute = (YIUIInvokeSystemAttribute)type.GetCustomAttribute(typeof(YIUIInvokeSystemAttribute), true);

                var entityType    = iSystemType.Type();
                var systemType    = iSystemType.SystemType();
                var attributeType = attribute.Type;

                if (!m_AllInvokers.TryGetValue(entityType, out var entityTypeDict))
                {
                    entityTypeDict = new();
                    m_AllInvokers.Add(entityType, entityTypeDict);
                }

                if (!entityTypeDict.TryGetValue(systemType, out var systemTypeDict))
                {
                    systemTypeDict = new();
                    entityTypeDict.Add(systemType, systemTypeDict);
                }

                if (!systemTypeDict.TryAdd(attributeType, obj))
                {
                    Log.Error($"重复添加YIUIInvoke请检查{entityType.Name} >> {attributeType} \ntype:{type.Name} \nentityType:{entityType.Name} \nsystemType:{systemType.Name} \nattributeType:{attributeType}");
                }
            }
        }

        private T GetInvoker<T>(Entity self, string attributeType)
        {
            if (self == null)
            {
                Log.Error($"Entity 不能为null");
                return default;
            }

            if (m_AllInvokers.TryGetValue(self.GetType(), out var entityTypeDict) && entityTypeDict.TryGetValue(typeof(T), out var systemTypeDict) && systemTypeDict.TryGetValue(attributeType, out var invoker))
            {
                if (invoker is T tInvoker)
                {
                    return tInvoker;
                }

                Log.Error($"找到YIUIInvoke实现请 但类型不一致请检查{self.GetType().Name} >> {attributeType}  需求:{typeof(T).Name} 实际:{invoker.GetType().Name}");
                return default;
            }

            Log.Error($"未找到YIUIInvoke实现请检查{self.GetType().Name} >> {attributeType}  类型:{typeof(T).Name}");
            return default;
        }
    }
}