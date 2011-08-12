using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator
{
	//Generator class for password generation
	public class Generator
	{
		const string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		const string NUMBERS = "1234567890";
		const string SPECIALCHARS = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
		
		public int PasswordLength { get; set; }
		public bool UseUpperCaseLetters { get; set; }
		public bool UseLowerCaseLetters { get; set; }
		public bool UseNumbers { get; set;}
		public bool UseSpecialCharacters { get; set; }
		
		public Generator (int passwordLength, bool useUpperCaseLetters, bool useLowerCaseLetters, bool useNumbers, bool useSpecialCharacters)
		{
			this.PasswordLength = passwordLength;
			this.UseUpperCaseLetters = useUpperCaseLetters;
			this.UseLowerCaseLetters = useLowerCaseLetters;
			this.UseNumbers = useNumbers;
			this.UseSpecialCharacters = useSpecialCharacters;
		}
		
		public string GeneratePassword()
		{
			int seedValue = GetRandomSeedValue(DateTime.Now.Hour);
			Random random = new Random(seedValue);
			IList<char> itemsToUse = GetItemsToUse();			
			StringBuilder password = new StringBuilder();
			
			while(password.Length < PasswordLength)
			{
				password.Append(itemsToUse[random.Next(itemsToUse.Count)]);
			}
			
			return password.ToString();
		}
		
		private int GetRandomSeedValue(int totalRotations)
		{
			int output = 0;
			for(int rotations = 0; rotations < totalRotations; rotations++)
			{
				Guid guid = System.Guid.NewGuid();
				foreach(byte b in guid.ToByteArray())
					output += (int)b;
			}
			
			return output;
		}
		
		private IList<char> GetItemsToUse()
		{
			IList<char> itemsToUse = new List<char>();
			
			if (UseUpperCaseLetters)
				GetUpperCaseLetters(ref itemsToUse);
			
			if (UseLowerCaseLetters)
				GetLowerCaseLetters(ref itemsToUse);
			
			if (UseNumbers)
				GetNumbers(ref itemsToUse);
			
			if (UseSpecialCharacters)
				GetSpecialCharacters(ref itemsToUse);
			
			return itemsToUse;
		}
		
		private void GetUpperCaseLetters(ref IList<char> itemsToUse)
		{
			foreach(char c in LETTERS.ToCharArray())
			{
				itemsToUse.Add(c);
			}
		}
		
		private void GetLowerCaseLetters(ref IList<char> itemsToUse)
		{
			foreach(char c in LETTERS.ToLowerInvariant().ToCharArray())
			{
				itemsToUse.Add(c);
			}
		}
		
		private void GetNumbers(ref IList<char> itemsToUse)
		{
			foreach (char c in NUMBERS.ToCharArray()) 
			{
				itemsToUse.Add(c);
			}
		}
		
		private void GetSpecialCharacters(ref IList<char> itemsToUse)
		{
			foreach (char c in SPECIALCHARS.ToCharArray())
			{
				itemsToUse.Add(c);
			}
		}
	}
}
