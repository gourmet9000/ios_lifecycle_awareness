using System;
using Android.Arch.Lifecycle;
using Java.Interop;

namespace AndroidSampleApp
{
    public class SampleFragmentObserver : Java.Lang.Object, ILifecycleObserver
    {
        [Lifecycle.Event.OnResume]
        [Export]
        public void InvokeSomeApiCall()
        {
            Console.WriteLine("Hello from ViewDidAppear");
        }
    }
}