using System.Collections.Generic;

namespace LifecycleAwarenessForViewController
{
    public interface ILifecycle
    {
        LifecycleState CurrentState { get; }

        void AddObserver(ILifecycleObserver lifecycleObserver);

        void AddObservers(IEnumerable<ILifecycleObserver> lifecycleObservers);

        void RemoveObserver(ILifecycleObserver lifecycleObserver);

        bool IsAtLeast(LifecycleState lifecycleState);
    }
}