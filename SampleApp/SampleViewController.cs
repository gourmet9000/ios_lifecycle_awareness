using System.Collections.Generic;
using LifecycleAwarenessForViewController;

namespace SampleApp
{
    public class SampleViewController : LifecycleProvidingViewController
    {
        //TODO dependency injection
        public SampleViewController(IEnumerable<ILifecycleObserver> observers)
        {
            Lifecycle.AddObservers(observers);
        }   
    }
}