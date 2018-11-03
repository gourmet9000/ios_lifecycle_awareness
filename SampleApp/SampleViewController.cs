using System.Collections.Generic;
using LifecycleAwarenessForViewController;

namespace SampleApp
{
    public class SampleViewController : LifecycleProvidingViewController
    {
        //TODO dependency injection
        public SampleViewController(IEnumerable<LifecycleObserver> observers)
        {
            foreach (var observer in observers)
            {
                Lifecycle.AddObserver(observer);
            }
        }
        
    }
}