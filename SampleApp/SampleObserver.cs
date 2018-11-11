using System;
using LifecycleAwarenessForViewController;
using PlatformAgnosticComponents;

namespace SampleApp
{
    public class SampleObserver : ILifecycleObserver
    {
        private ISampleObserverDelegate _sampleObserverDelegate;

        public SampleObserver(ISampleObserverDelegate sampleObserverDelegate)
        {
            _sampleObserverDelegate = sampleObserverDelegate;
        }

        [LifecycleAwareMethod(LifecycleEvent = LifecycleEvent.ViewDidAppear)]
        public void InvokeSomeApiCall()
        {
            _sampleObserverDelegate.InvokeSomeApiCall();
        }
    }
}