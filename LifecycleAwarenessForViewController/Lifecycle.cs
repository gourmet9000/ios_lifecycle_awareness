namespace LifecycleAwarenessForViewController
{
    public interface Lifecycle
    {
        LifecycleState CurrentState { get; }

        void AddObserver(LifecycleObserver lifecycleObserver);

        void RemoveObserver(LifecycleObserver lifecycleObserver);

        bool IsAtLeast(LifecycleState lifecycleState);
    }
}