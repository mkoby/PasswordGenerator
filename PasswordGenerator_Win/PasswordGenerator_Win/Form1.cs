using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator_Win
{
    public partial class Form1 : Form
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

        private void SetGeneratorOptions(CheckBox cb)
        {
            switch (cb.Text)
            {
                case "Use Uppercase Letters":
                    gen.UseUpperCaseLetters = cb.Checked;
                    break;
                case "Use Lowercase Letters":
                    gen.UseLowerCaseLetters = cb.Checked;
                    break;
                case "Use Numbers":
                    gen.UseNumbers = cb.Checked;
                    break;
                case "Use Special Characters":
                    gen.UseSpecialCharacters = cb.Checked;
                    break;
            }
        }
        public Form1()
        {
            InitializeComponent();

            gen = new PasswordGenerator.Generator(14, useUppercase, useLowercase,
                                              useNumbers, useSpecialCharacters);
        }

        private void CheckboxCheckStateChanged(object sender, EventArgs e)
        {
            SetGeneratorOptions((CheckBox)sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetPasswordLength(PasswordLengthText.Text);
            GeneratedPasswordText.Text = gen.GeneratePassword();
        }
    }
}
