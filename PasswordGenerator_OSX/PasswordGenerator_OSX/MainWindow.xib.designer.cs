// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace PasswordGeneratorOSX {
	
	
	// Should subclass MonoMac.AppKit.NSWindow
	[MonoMac.Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[MonoMac.Foundation.Register("MainWindowController")]
	public partial class MainWindowController {
		
		private global::MonoMac.AppKit.NSTextField __mt_generatedPasswordText;
		
		private global::MonoMac.AppKit.NSTextField __mt_passwordLengthText;
		
		#pragma warning disable 0169
		[MonoMac.Foundation.Export("generatePasswordClicked:")]
		partial void generatePasswordClicked (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Export("useLowerCaseLettersPressed:")]
		partial void useLowerCaseLettersPressed (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Export("useNumbersPressed:")]
		partial void useNumbersPressed (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Export("useSpecialCharactersPressed:")]
		partial void useSpecialCharactersPressed (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Export("useUppercaseLettersPressed:")]
		partial void useUppercaseLettersPressed (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Connect("generatedPasswordText")]
		private global::MonoMac.AppKit.NSTextField generatedPasswordText {
			get {
				this.__mt_generatedPasswordText = ((global::MonoMac.AppKit.NSTextField)(this.GetNativeField("generatedPasswordText")));
				return this.__mt_generatedPasswordText;
			}
			set {
				this.__mt_generatedPasswordText = value;
				this.SetNativeField("generatedPasswordText", value);
			}
		}
		
		[MonoMac.Foundation.Connect("passwordLengthText")]
		private global::MonoMac.AppKit.NSTextField passwordLengthText {
			get {
				this.__mt_passwordLengthText = ((global::MonoMac.AppKit.NSTextField)(this.GetNativeField("passwordLengthText")));
				return this.__mt_passwordLengthText;
			}
			set {
				this.__mt_passwordLengthText = value;
				this.SetNativeField("passwordLengthText", value);
			}
		}
	}
}