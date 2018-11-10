namespace LifecycleAwarenessForViewController
{
    public interface ILifecycle
    {
        LifecycleState CurrentState { get; }

        void AddObserver(ILifecycleObserver lifecycleObserver);

        void RemoveObserver(ILifecycleObserver lifecycleObserver);

        bool IsAtLeast(LifecycleState lifecycleState);
    }
}