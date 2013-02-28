using System;
using MonoTouch.UIKit;

namespace fullScreenApp
{
	public class FullScreenController : UIViewController
	{
		public FullScreenController ()
		{
			//statusbar is hidden
			UIApplication.SharedApplication.SetStatusBarHidden (true, UIStatusBarAnimation.None);

			UIView view = new UIView (this.View.Frame);
			view.BackgroundColor = UIColor.White;
			this.View.AddSubview(view);
		}
	}
}

