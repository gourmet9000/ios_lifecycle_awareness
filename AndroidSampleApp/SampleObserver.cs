using System;
using Android.Arch.Lifecycle;
using Java.Interop;
using PlatformAgnosticComponents;

namespace AndroidSampleApp
{
    public class SampleObserver : Java.Lang.Object, ILifecycleObserver
    {
        private ISampleObserverDelegate _sampleObserverDelegate;

        public SampleObserver(ISampleObserverDelegate sampleObserverDelegate)
        {
            _sampleObserverDelegate = sampleObserverDelegate;
        }

        [Lifecycle.Event.OnResume]
        [Export]
        public void InvokeSomeApiCall()
        {
            _sampleObserverDelegate.InvokeSomeApiCall();
        }
    }
}