using System;
using Android.Arch.Lifecycle;
using Java.Interop;
using PlatformAgnosticComponents;

namespace AndroidSampleApp
{
    public class SampleObserverProxy : Java.Lang.Object, ILifecycleObserver
    {
        private ISampleObserver _sampleObserver;

        public SampleObserverProxy(ISampleObserver sampleObserver)
        {
            _sampleObserver = sampleObserver;
        }

        [Lifecycle.Event.OnResume]
        [Export]
        public void InvokeSomeApiCall()
        {
            _sampleObserver.InvokeSomeApiCall();
        }
    }
}