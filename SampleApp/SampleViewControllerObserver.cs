using System;
using LifecycleAwarenessForViewController;

namespace SampleApp
{
    public class SampleViewControllerObserver : LifecycleObserver
    {

        [LifecycleAwareMethod(LifecycleEvent = LifecycleEvent.ViewDidAppear)]
        public void InvokeSomeApiCall()
        {
            Console.WriteLine("Hello from ViewDidAppear");
        }
    }
}