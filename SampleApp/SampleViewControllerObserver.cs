using System;
using LifecycleAwarenessForViewController;

namespace SampleApp
{
    public class SampleViewControllerObserver : ILifecycleObserver
    {

        [LifecycleAwareMethod(LifecycleEvent = LifecycleEvent.ViewDidAppear)]
        public void InvokeSomeApiCall()
        {
            Console.WriteLine("Hello from ViewDidAppear");
        }
    }
}