using System;
using System.Collections.Generic;
using System.Reflection;

namespace ET
{
    [CodeProcess]
    public partial class YIUIInvokeSystem : Singleton<YIUIInvokeSystem>, ISingletonAwake
    {
        private readonly Dictionary<string, object> m_AllInvokers = new();

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

                var attribute     = (YIUIInvokeSystemAttribute)type.GetCustomAttribute(typeof(YIUIInvokeSystemAttribute), true);
                var attributeType = attribute.Type;

                if (!m_AllInvokers.TryAdd(attributeType, obj))
                {
                    var entityType = iSystemType.Type();
                    var systemType = iSystemType.SystemType();
                    Log.Error($"重复添加YIUIInvoke请检查{entityType.Name} >> {attributeType} \ntype:{type.Name} \nentityType:{entityType.Name} \nsystemType:{systemType.Name} \nattributeType:{attributeType}");
                }
            }
        }

        private T GetInvoker<T>(string attributeType)
        {
            if (m_AllInvokers.TryGetValue(attributeType, out var invoker))
            {
                if (invoker is T tInvoker)
                {
                    return tInvoker;
                }

                Log.Error($"找到YIUIInvoke实现请 但类型不一致请检查 {attributeType}  需求:{typeof(T).Name} 实际:{invoker.GetType().Name}");
                return default;
            }

            Log.Error($"未找到YIUIInvoke实现请检查 {attributeType}  类型:{typeof(T).Name}");
            return default;
        }
    }
}