using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using PasswordGenerator;

namespace PasswordGenerator_monodroid
{	
	[Activity (Label = "PasswordGenerator_monodroid", MainLauncher = true)]
	public class Activity1 : Activity
	{
		Generator generator = null;
		Button generatePasswordButton = null;
		EditText generatedPassword = null;
		CheckBox useUppercaseLettersCheckbox = null, 
				 useLowercaseLettersCheckbox = null, 
				 useNumbersCheckbox = null, 
				 useSpecialCharactersCheckbox = null;
		Spinner passwordLengthSpinner = null;
		
		void SetupView()
		{
			//Get UI Object Resources & Attach Them to Objects
			generatePasswordButton = FindViewById<Button> (Resource.Id.myButton);
			generatedPassword = FindViewById<EditText>(Resource.Id.generatedPasswordText);
			useUppercaseLettersCheckbox = FindViewById<CheckBox>(Resource.Id.useUppercaseLetters);
			useLowercaseLettersCheckbox = FindViewById<CheckBox>(Resource.Id.useLowercaseLetters);
			useNumbersCheckbox = FindViewById<CheckBox>(Resource.Id.useNumbers);
			useSpecialCharactersCheckbox = FindViewById<CheckBox>(Resource.Id.useSpecialCharacters);
			
			//Set Checkboxes to match default settings
			useUppercaseLettersCheckbox.Checked = true;
			useLowercaseLettersCheckbox.Checked = true;
			useNumbersCheckbox.Checked = true;
			useSpecialCharactersCheckbox.Checked = true;
			
			//Configure Spinner for Password Length Selection
			passwordLengthSpinner = FindViewById<Spinner>(Resource.Id.passwordLengthSpinner);
			var adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.password_length_array, Android.Resource.Layout.SimpleSpinnerItem);
			adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
			passwordLengthSpinner.Adapter = adapter;
			passwordLengthSpinner.SetSelection(3); //Set Length Spinner to show default length value
			
			//Event Handlers
			passwordLengthSpinner.ItemSelected += HandlePasswordLengthSpinnerItemSelected;			
			useUppercaseLettersCheckbox.Click += HandleCheckboxClicked;			
			useLowercaseLettersCheckbox.Click += HandleCheckboxClicked;			
			useNumbersCheckbox.Click += HandleCheckboxClicked;			
			useSpecialCharactersCheckbox.Click += HandleCheckboxClicked;
			
			generatePasswordButton.Click += delegate {
				generatedPassword.Text = generator.GeneratePassword(); };
		}

		void HandlePasswordLengthSpinnerItemSelected (object sender, ItemEventArgs e)
		{
			Spinner spinner = (Spinner)sender;
			int passwordLength = generator.PasswordLength;
			int.TryParse(spinner.GetItemAtPosition(e.Position).ToString(), out passwordLength);			
			generator.PasswordLength = passwordLength;
		}
		
		void HandleCheckboxClicked(object sender, EventArgs e)
		{
			CheckBox cb = (CheckBox)sender;
			
			switch(cb.Text)
			{
				case "Use Uppercase Letters":
					generator.UseUpperCaseLetters = cb.Checked;
				break;
				case "Use Lowercase Letters":
					generator.UseLowerCaseLetters = cb.Checked;
				break;
				case "Use Numbers":
					generator.UseNumbers = cb.Checked;
				break;
				case "Use Special Characters":
					generator.UseSpecialCharacters = cb.Checked;
				break;
			}
			
			Console.WriteLine("{0} Checked: {1}", cb.Text, cb.Checked);
		}
		
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			this.generator = new Generator(14, true, true, true, true);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			
			SetupView();
		}
	}
}


