using System;
using LifecycleAwarenessForViewController;
using PlatformAgnosticComponents;

namespace SampleApp
{
    public class SampleObserverProxy : ILifecycleObserver
    {
        private ISampleObserver _sampleObserver;

        public SampleObserverProxy(ISampleObserver sampleObserver)
        {
            _sampleObserver = sampleObserver;
        }

        [LifecycleAwareMethod(LifecycleEvent = LifecycleEvent.ViewDidAppear)]
        public void InvokeSomeApiCall()
        {
            _sampleObserver.InvokeSomeApiCall();
        }
    }
}