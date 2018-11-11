using System.Collections.Generic;
using Android.Arch.Lifecycle;
using Android.Support.V4.App;

namespace AndroidSampleApp
{
    public class SampleFragment : Fragment
    {
        public SampleFragment(IEnumerable<ILifecycleObserver> lifecycleObservers)
        {
            foreach (var lifecycleObserver  in lifecycleObservers)
            {
                Lifecycle.AddObserver(lifecycleObserver);
            }
        }
    }
}