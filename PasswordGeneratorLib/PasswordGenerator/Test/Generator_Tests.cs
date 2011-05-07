using System;
using NUnit.Framework;
using PasswordGenerator;

namespace PasswordGenerator
{
	[TestFixture]
	public class Generator_Tests
	{
		const string LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		const string NUMBERS = "1234567890";
		const string SPECIALCHARS = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
		
		[Test]
		public void Generator_With_Options_Is_Created_Accordingly()
		{
			Generator gen = new Generator( 15, true, true, true, true );
			Assert.AreEqual(15, gen.PasswordLength);
			Assert.IsTrue(gen.UseSpecialCharacters);
		}
		
		[Test]
		public void Generates_a_Password_9_Characters_Long()
		{
			Generator gen = new Generator( 9, true, true, false, true );
			string password = gen.GeneratePassword();
			Assert.AreEqual(9, password.Length);
		}
		
		[Test]
		public void Generates_a_Password_with_No_Numbers()
		{
			Generator gen = new Generator( 15, true, true, false, true );
			string password = gen.GeneratePassword();
			foreach (char c in password.ToCharArray()) 
			{
				Assert.IsFalse(NUMBERS.Contains(c.ToString()));
			}
		}
		
		[Test]
		public void Generates_a_Password_with_No_Special_Characters()
		{
			Generator gen = new Generator( 15, true, true, true, false );
			string password = gen.GeneratePassword();
			foreach (char c in password.ToCharArray()) 
			{
				Assert.IsFalse(SPECIALCHARS.Contains(c.ToString()));
			}
		}
		
		[Test]
		public void Generates_a_Password_with_Only_Numbers()
		{
			Generator gen = new Generator( 8, false, false, true, false );
			string password = gen.GeneratePassword();
			foreach (char c in password.ToCharArray()) 
			{
				Assert.IsTrue(NUMBERS.Contains(c.ToString()));
			}
		}
		
		[Test]
		public void Generates_a_Password_with_Only_Lower_Case_Letters()
		{
			Generator gen = new Generator( 8, false, true, false, false );
			string password = gen.GeneratePassword();
			foreach (char c in password.ToCharArray()) 
			{
				Assert.IsTrue(LETTERS.ToLowerInvariant().Contains(c.ToString()));
			}
		}
		
		[Test]
		public void Generates_a_Password_with_Only_Upper_Case_Letters()
		{
			Generator gen = new Generator( 8, true, false, false, false );
			string password = gen.GeneratePassword();
			foreach (char c in password.ToCharArray()) 
			{
				Assert.IsTrue(LETTERS.Contains(c.ToString()));
			}
		}
	}
}
