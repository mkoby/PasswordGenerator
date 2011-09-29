using MonoTouch.UIKit;
using System.Drawing;
using System;
using MonoTouch.Foundation;
using PasswordGenerator;

namespace PasswordGeneratormonotouch
{
	public partial class PasswordGenerator_monotouchViewController : UIViewController
	{
		Generator passwordGenerator;
		
		partial void sliderChanged (MonoTouch.Foundation.NSObject sender)
		{
			UISlider passwordLengthSlider = (UISlider)sender;
			int sliderValueAsInt = Convert.ToInt32(passwordLengthSlider.Value);
			passwordLengthLabel.Text = sliderValueAsInt.ToString();
			
			passwordGenerator.PasswordLength = sliderValueAsInt;
		}
		
		partial void switchedStatusChanged (MonoTouch.Foundation.NSObject sender)
		{
			UISwitch changedSwitch = (UISwitch)sender;
			switch(changedSwitch.Tag)
			{
				case 0:
					passwordGenerator.UseUpperCaseLetters = changedSwitch.On;
					break;
				case 1:
					passwordGenerator.UseLowerCaseLetters = changedSwitch.On;
					break;
				case 2:
					passwordGenerator.UseNumbers = changedSwitch.On;
					break;
				case 3:
					passwordGenerator.UseSpecialCharacters = changedSwitch.On;
					break;
			}
			
			Console.WriteLine("UseUpperCaseLetters: {0}\nUseLowerCaseLetters: {1}\nUseNumbers: {2}\nUseSpecialCharacters: {3}", passwordGenerator.UseUpperCaseLetters, passwordGenerator.UseLowerCaseLetters, passwordGenerator.UseNumbers, passwordGenerator.UseSpecialCharacters);
		}
		
		partial void generatePassword (MonoTouch.Foundation.NSObject sender)
		{
			generatedPasswordText.Text = passwordGenerator.GeneratePassword();
		}
		
		public PasswordGenerator_monotouchViewController (string nibName, NSBundle bundle) : base (nibName, bundle)
		{
			passwordGenerator = new Generator(14, true, true, true, true);
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			//any additional setup after loading the view, typically from a nib.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Release any retained subviews of the main view.
			// e.g. myOutlet = null;
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation == UIInterfaceOrientation.Portrait);
		}
	}
}
