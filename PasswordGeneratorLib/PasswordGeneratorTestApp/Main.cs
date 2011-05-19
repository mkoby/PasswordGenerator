using System;

namespace PasswordGeneratorTestApp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool useUpperCaseLetters = true;
			bool useLowerCaseLetters = true;
			bool useNumbers = true;
			bool useSpecialCharacters = true;
			
			//All Options
			var gen = new PasswordGenerator.Generator(GetRandomPasswordLength(), useUpperCaseLetters, useLowerCaseLetters, useNumbers, useSpecialCharacters);
			Console.WriteLine("All Options: {0}", gen.GeneratePassword());
			
			//No Special Characters
			gen = new PasswordGenerator.Generator(GetRandomPasswordLength(), useUpperCaseLetters, useLowerCaseLetters, useNumbers, false);
			Console.WriteLine("No Special Characters: {0}", gen.GeneratePassword());
			
			//No Numbers
			gen = new PasswordGenerator.Generator(GetRandomPasswordLength(), useUpperCaseLetters, useLowerCaseLetters, false, useSpecialCharacters);
			Console.WriteLine("No Numbers: {0}", gen.GeneratePassword());
			
			//No Lower Case Characters
			gen = new PasswordGenerator.Generator(GetRandomPasswordLength(), useUpperCaseLetters, false, useNumbers, useSpecialCharacters);
			Console.WriteLine("No Lower Case Characters: {0}", gen.GeneratePassword());
			
			//No Upper Case Characters
			gen = new PasswordGenerator.Generator(GetRandomPasswordLength(), false, useLowerCaseLetters, useNumbers, useSpecialCharacters);
			Console.WriteLine("No Upper Case Characters: {0}", gen.GeneratePassword());
		}
		
		private static int GetRandomPasswordLength()
		{
			Random random = new Random(DateTime.Now.Millisecond);
			return random.Next(21);
		}
	}
}

