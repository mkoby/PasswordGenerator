// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.Fixed fixed1;
    
    private Gtk.Label label2;
    
    private Gtk.Entry PasswordLengthText;
    
    private Gtk.CheckButton UseUppercaseCheckbox;
    
    private Gtk.CheckButton UseLowerCaseCheckbox;
    
    private Gtk.CheckButton UseNumbersCheckbox;
    
    private Gtk.CheckButton UseSpecialCharactersCheckbox;
    
    private Gtk.Button GeneratePasswordButton;
    
    private Gtk.Entry GeneratedPasswordText;
    
    private Gtk.Label label3;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("Password Generator (GTK)");
        this.WindowPosition = ((Gtk.WindowPosition)(4));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.fixed1 = new Gtk.Fixed();
        this.fixed1.Name = "fixed1";
        this.fixed1.HasWindow = false;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.label2 = new Gtk.Label();
        this.label2.Name = "label2";
        this.label2.LabelProp = Mono.Unix.Catalog.GetString("Password Length");
        this.fixed1.Add(this.label2);
        Gtk.Fixed.FixedChild w1 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
        w1.X = 13;
        w1.Y = 23;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.PasswordLengthText = new Gtk.Entry();
        this.PasswordLengthText.CanFocus = true;
        this.PasswordLengthText.Name = "PasswordLengthText";
        this.PasswordLengthText.Text = Mono.Unix.Catalog.GetString("14");
        this.PasswordLengthText.IsEditable = true;
        this.PasswordLengthText.WidthChars = 7;
        this.PasswordLengthText.MaxLength = 2;
        this.PasswordLengthText.InvisibleChar = '●';
        this.fixed1.Add(this.PasswordLengthText);
        Gtk.Fixed.FixedChild w2 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.PasswordLengthText]));
        w2.X = 127;
        w2.Y = 16;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.UseUppercaseCheckbox = new Gtk.CheckButton();
        this.UseUppercaseCheckbox.CanFocus = true;
        this.UseUppercaseCheckbox.Name = "UseUppercaseCheckbox";
        this.UseUppercaseCheckbox.Label = Mono.Unix.Catalog.GetString("Use Uppercase Letters");
        this.UseUppercaseCheckbox.Active = true;
        this.UseUppercaseCheckbox.DrawIndicator = true;
        this.UseUppercaseCheckbox.UseUnderline = true;
        this.fixed1.Add(this.UseUppercaseCheckbox);
        Gtk.Fixed.FixedChild w3 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.UseUppercaseCheckbox]));
        w3.X = 250;
        w3.Y = 8;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.UseLowerCaseCheckbox = new Gtk.CheckButton();
        this.UseLowerCaseCheckbox.CanFocus = true;
        this.UseLowerCaseCheckbox.Name = "UseLowerCaseCheckbox";
        this.UseLowerCaseCheckbox.Label = Mono.Unix.Catalog.GetString("Use Lowercase Letters");
        this.UseLowerCaseCheckbox.Active = true;
        this.UseLowerCaseCheckbox.DrawIndicator = true;
        this.UseLowerCaseCheckbox.UseUnderline = true;
        this.fixed1.Add(this.UseLowerCaseCheckbox);
        Gtk.Fixed.FixedChild w4 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.UseLowerCaseCheckbox]));
        w4.X = 251;
        w4.Y = 37;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.UseNumbersCheckbox = new Gtk.CheckButton();
        this.UseNumbersCheckbox.CanFocus = true;
        this.UseNumbersCheckbox.Name = "UseNumbersCheckbox";
        this.UseNumbersCheckbox.Label = Mono.Unix.Catalog.GetString("Use Numbers");
        this.UseNumbersCheckbox.Active = true;
        this.UseNumbersCheckbox.DrawIndicator = true;
        this.UseNumbersCheckbox.UseUnderline = true;
        this.fixed1.Add(this.UseNumbersCheckbox);
        Gtk.Fixed.FixedChild w5 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.UseNumbersCheckbox]));
        w5.X = 427;
        w5.Y = 8;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.UseSpecialCharactersCheckbox = new Gtk.CheckButton();
        this.UseSpecialCharactersCheckbox.CanFocus = true;
        this.UseSpecialCharactersCheckbox.Name = "UseSpecialCharactersCheckbox";
        this.UseSpecialCharactersCheckbox.Label = Mono.Unix.Catalog.GetString("Use Special Characters");
        this.UseSpecialCharactersCheckbox.Active = true;
        this.UseSpecialCharactersCheckbox.DrawIndicator = true;
        this.UseSpecialCharactersCheckbox.UseUnderline = true;
        this.fixed1.Add(this.UseSpecialCharactersCheckbox);
        Gtk.Fixed.FixedChild w6 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.UseSpecialCharactersCheckbox]));
        w6.X = 428;
        w6.Y = 35;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.GeneratePasswordButton = new Gtk.Button();
        this.GeneratePasswordButton.CanFocus = true;
        this.GeneratePasswordButton.Name = "GeneratePasswordButton";
        this.GeneratePasswordButton.UseUnderline = true;
        this.GeneratePasswordButton.Label = Mono.Unix.Catalog.GetString("Generate Password");
        this.fixed1.Add(this.GeneratePasswordButton);
        Gtk.Fixed.FixedChild w7 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.GeneratePasswordButton]));
        w7.X = 467;
        w7.Y = 68;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.GeneratedPasswordText = new Gtk.Entry();
        this.GeneratedPasswordText.CanFocus = true;
        this.GeneratedPasswordText.Name = "GeneratedPasswordText";
        this.GeneratedPasswordText.IsEditable = false;
        this.GeneratedPasswordText.WidthChars = 32;
        this.GeneratedPasswordText.MaxLength = 32;
        this.GeneratedPasswordText.InvisibleChar = '●';
        this.fixed1.Add(this.GeneratedPasswordText);
        Gtk.Fixed.FixedChild w8 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.GeneratedPasswordText]));
        w8.X = 268;
        w8.Y = 118;
        // Container child fixed1.Gtk.Fixed+FixedChild
        this.label3 = new Gtk.Label();
        this.label3.Name = "label3";
        this.label3.LabelProp = Mono.Unix.Catalog.GetString("Generated Password");
        this.fixed1.Add(this.label3);
        Gtk.Fixed.FixedChild w9 = ((Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
        w9.X = 128;
        w9.Y = 122;
        this.Add(this.fixed1);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 626;
        this.DefaultHeight = 193;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
        this.UseUppercaseCheckbox.Toggled += new System.EventHandler(this.CheckboxToggled);
        this.UseLowerCaseCheckbox.Toggled += new System.EventHandler(this.CheckboxToggled);
        this.UseNumbersCheckbox.Toggled += new System.EventHandler(this.CheckboxToggled);
        this.UseSpecialCharactersCheckbox.Toggled += new System.EventHandler(this.CheckboxToggled);
        this.GeneratePasswordButton.Clicked += new System.EventHandler(this.OnGeneratePasswordButtonClicked);
    }
}
