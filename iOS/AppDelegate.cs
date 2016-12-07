using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Microsoft.Azure.Mobile;
using UIKit;

namespace MobileCenterTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			MobileCenter.Configure("8d7a5dc1-b25e-4587-97d7-82636a60667b");

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
