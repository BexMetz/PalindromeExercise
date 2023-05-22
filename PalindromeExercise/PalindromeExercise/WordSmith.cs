using System;
using System.Linq;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{
		}

		public bool IsAPalindrome(string word)
		{
			char[] wordArray = word.ToCharArray();
			Array.Reverse(wordArray);
			var reversed = new string (wordArray);
			if (reversed == word)
			{
				return true;
			}
			return false;
		}
	}
}

