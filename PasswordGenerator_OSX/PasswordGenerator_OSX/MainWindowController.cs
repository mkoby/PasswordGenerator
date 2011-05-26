
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using PasswordGenerator;

namespace PasswordGeneratorOSX
{
	public partial class MainWindowController : MonoMac.AppKit.NSWindowController
	{
		//Define the basic password generator object
		//This will change as options are modified
		private static bool useUppercaseLetters = true, useLowercaseLetters = true, useNumbers = true, useSpecialCharacters = true;
		private PasswordGenerator.Generator gen = new Generator(14, useUppercaseLetters, useLowercaseLetters, useNumbers, useSpecialCharacters);
		
		
		#region Constructors				

		// Called when created from unmanaged code
		public MainWindowController (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		// Call to load from the XIB/NIB file
		public MainWindowController () : base("MainWindow")
		{
			Initialize ();
		}

		// Shared initialization code
		void Initialize ()
		{
		}

		#endregion

		//strongly typed window accessor
		public new MainWindow Window {
			get { return (MainWindow)base.Window; }
		}
		
		partial void useUppercaseLettersPressed (NSButton sender)
		{
			if( sender.IntValue == 0 )
				useUppercaseLetters = false;
			else
				useUppercaseLetters = true;
		}
		
		partial void useLowerCaseLettersPressed (NSButton sender)
		{
			if( sender.IntValue == 0 )
				useLowercaseLetters = false;
			else
				useLowercaseLetters = true;
		}
		
		partial void useNumbersPressed (NSButton sender)
		{
			if( sender.IntValue == 0 )
				useNumbers = false;
			else
				useNumbers = true;
		}
		
		partial void useSpecialCharactersPressed (NSButton sender)
		{
			if( sender.IntValue == 0 )
				useSpecialCharacters = false;
			else
				useSpecialCharacters = true;
		}
		
		partial void generatePasswordClicked (NSButton sender)
		{
			gen = new Generator(Int32.Parse( passwordLengthText.StringValue ), 
			                    useUppercaseLetters, 
			                    useLowercaseLetters, 
			                    useNumbers, 
			                    useSpecialCharacters);
			generatedPasswordText.StringValue = gen.GeneratePassword();
		}
	}
}

