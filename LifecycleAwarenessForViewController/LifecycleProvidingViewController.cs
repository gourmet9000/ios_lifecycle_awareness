using UIKit;

namespace LifecycleAwarenessForViewController
{
    public class LifecycleProvidingViewController : UIViewController, LifecycleOwner
    {
        private readonly LifecycleRegistry _lifecycleRegistry = new LifecycleRegistry();

        public ILifecycle Lifecycle => _lifecycleRegistry;

        public LifecycleProvidingViewController()
        {
            _lifecycleRegistry.LifecycleOwner = this; 
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _lifecycleRegistry.HandleLifecycleEvent(LifecycleEvent.ViewDidLoad);
        }

        public override void ViewWillAppear(bool animated)
        {
            _lifecycleRegistry.HandleLifecycleEvent(LifecycleEvent.ViewWillAppear);
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            _lifecycleRegistry.HandleLifecycleEvent(LifecycleEvent.ViewDidAppear);
        }

        public override void ViewWillDisappear(bool animated)
        {
            _lifecycleRegistry.HandleLifecycleEvent(LifecycleEvent.ViewWillDisappear);
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            _lifecycleRegistry.HandleLifecycleEvent(LifecycleEvent.ViewDidDisappear);
        }
    }
}