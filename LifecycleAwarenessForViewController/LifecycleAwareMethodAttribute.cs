using System;

namespace LifecycleAwarenessForViewController
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LifecycleAwareMethodAttribute : Attribute
    {
        public LifecycleEvent LifecycleEvent { get; set; }
    }
}