using System;
using System.Collections.Generic;

namespace LifecycleAwarenessForViewController
{
    public class LifecycleRegistry : ILifecycle
    {
        private IList<ILifecycleObserver> _lifecycleObservers = new List<ILifecycleObserver>();

        public LifecycleOwner LifecycleOwner { get; set; }
        public LifecycleEvent CurrentEvent { get; private set; }
        public LifecycleState CurrentState { get; private set; }

        public void AddObserver(ILifecycleObserver lifecycleObserver)
        {
            _lifecycleObservers.Add(lifecycleObserver);
        }

        public void RemoveObserver(ILifecycleObserver lifecycleObserver)
        {
            _lifecycleObservers.Remove(lifecycleObserver);
        }

        public bool IsAtLeast(LifecycleState lifecycleState)
        {
            return lifecycleState >= CurrentState;
        }

        public void HandleLifecycleEvent(LifecycleEvent lifecycleEvent)
        {
            CurrentEvent = lifecycleEvent;
            SetLifecycleStateAccordingTo(lifecycleEvent); 
            SyncObservers();
        }

        private void SetLifecycleStateAccordingTo(LifecycleEvent lifecycleEvent)
        {
            switch (lifecycleEvent)
            {
                case LifecycleEvent.ViewDidLoad:
                    CurrentState = LifecycleState.Loaded;
                    break; 
                case LifecycleEvent.ViewDidAppear:
                    CurrentState = LifecycleState.Appeared;
                    break; 
                case LifecycleEvent.ViewDidDisappear:
                    CurrentState = LifecycleState.Disappeared ;
                    break;
            }
        }

        private void SyncObservers()
        {
            foreach (var observer in _lifecycleObservers)
            {
                foreach (var method in observer.GetType().GetMethods())
                {
                    var lifecycleAwareMethod =
                        (LifecycleAwareMethodAttribute) Attribute.GetCustomAttribute(method, typeof(LifecycleAwareMethodAttribute));
                    if (lifecycleAwareMethod?.LifecycleEvent == CurrentEvent)
                    {
                        method.Invoke(observer, new object[] { });
                    }
                }
            }
        }
    }
}