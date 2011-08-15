using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	private static bool useUppercase = true, 
						useLowercase = true, 
						useNumbers = true, 
						useSpecialCharacters = true;
	private PasswordGenerator.Generator gen;
	
	private void SetPasswordLength(string newLength)
	{
		int newLengthValue = gen.PasswordLength;
		bool isNumber = int.TryParse(newLength, out newLengthValue);
		
		if (isNumber)
			gen.PasswordLength = newLengthValue;
		else
		{
			PasswordLengthText.Text = "14";
		}
	}
	
	private void SetGeneratorOptions(CheckButton cb)
	{
		switch(cb.Label)
		{
			case "Use Uppercase Letters":
				gen.UseUpperCaseLetters = cb.Active;
				break;
			case "Use Lowercase Letters":
				gen.UseLowerCaseLetters = cb.Active;
				break;
			case "Use Numbers":
				gen.UseNumbers = cb.Active;
				break;
			case "Use Special Characters":
				gen.UseSpecialCharacters = cb.Active;
				break;
		}
	}
	
	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		gen = new PasswordGenerator.Generator(14, useUppercase, useLowercase, 
		                                      useNumbers, useSpecialCharacters);
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected virtual void CheckboxToggled (object sender, System.EventArgs e)
	{
		SetGeneratorOptions((CheckButton)sender);
	}
	
	protected virtual void OnGeneratePasswordButtonClicked (object sender, System.EventArgs e)
	{
		SetPasswordLength(PasswordLengthText.Text);
		GeneratedPasswordText.Text = gen.GeneratePassword();
	}
	
	
}
