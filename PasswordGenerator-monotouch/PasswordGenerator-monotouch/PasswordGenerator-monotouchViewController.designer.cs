// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace PasswordGeneratormonotouch
{
	[Register ("PasswordGenerator_monotouchViewController")]
	partial class PasswordGenerator_monotouchViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel passwordLengthLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField generatedPasswordText { get; set; }

		[Action ("generatePassword:")]
		partial void generatePassword (MonoTouch.Foundation.NSObject sender);

		[Action ("switchedStatusChanged:")]
		partial void switchedStatusChanged (MonoTouch.Foundation.NSObject sender);

		[Action ("sliderChanged:")]
		partial void sliderChanged (MonoTouch.Foundation.NSObject sender);
	}
}
