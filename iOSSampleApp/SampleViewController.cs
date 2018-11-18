using System.Collections.Generic;
using LifecycleAwarenessForViewController;

namespace iOSSampleApp
{
    public class SampleViewController : LifecycleProvidingViewController
    {
        public SampleViewController(IEnumerable<ILifecycleObserver> observers)
        {
            Lifecycle.AddObservers(observers);
        }   
    }
}