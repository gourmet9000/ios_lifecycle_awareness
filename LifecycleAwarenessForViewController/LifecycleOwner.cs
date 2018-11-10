namespace LifecycleAwarenessForViewController
{
    public interface LifecycleOwner
    {
        ILifecycle Lifecycle { get; }
    }
}