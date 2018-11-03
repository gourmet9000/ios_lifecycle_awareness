using System;

namespace LifecycleAwarenessForViewController
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LifecycleAwareMethod : Attribute
    {
        public LifecycleEvent LifecycleEvent { get; set; }
    }
}