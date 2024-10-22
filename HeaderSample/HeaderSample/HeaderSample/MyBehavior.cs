using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if ANDROID
using PlatformView = Android.Views.View;
#elif IOS
using PlatformView = UIKit.UIView;
#else
using PlatformView = System.Object;
#endif

namespace HeaderSample
{
	internal class MyBehavior : Behavior
	{
		protected override void OnAttachedTo(BindableObject bindable)
		{
			base.OnAttachedTo(bindable);
			Console.WriteLine($"Attached behavior to {bindable}");
		}
	}

	internal class MyPlatformBehavior : PlatformBehavior<VisualElement, PlatformView>
	{
		protected override void OnAttachedTo(VisualElement bindable, PlatformView platformView)
		{
			base.OnAttachedTo(bindable, platformView);
			Console.WriteLine($"Attached platform behavior to {bindable}");
		}
	}
}
