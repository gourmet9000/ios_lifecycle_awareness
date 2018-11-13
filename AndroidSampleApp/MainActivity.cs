using System.Collections.Generic;
using Android.App;
using Android.Arch.Lifecycle;
using Android.OS;
using Android.Support.V7.App;
using PlatformAgnosticComponents;

namespace AndroidSampleApp
{
    [Activity(Label = "MainActivity", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        private const string _fragmentTag = "SampleFragmentTag";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            AddLifecycleFragment();
        }

        private void AddLifecycleFragment()
        {
            //TODO dependency injection
            var sampleFragmentObserver = new SampleObserverProxy(new SampleObserver());
            var sampleFragment = new SampleFragment(new List<ILifecycleObserver> { sampleFragmentObserver });
            SupportFragmentManager.BeginTransaction().Add(sampleFragment, _fragmentTag).Commit();
        }
    }
}