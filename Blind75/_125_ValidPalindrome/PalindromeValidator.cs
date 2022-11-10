using System.Text.RegularExpressions;

namespace _125_ValidPalindrome;

public class PalindromeValidator
{
    public static bool IsPalindrome(string s)
    {
        var reducedString = s.ToLower().ToCharArray().Where(c => Char.IsLetterOrDigit(c)).ToArray();

        var firstIndex = 0;
        var lastIndex = reducedString.Length - 1;

        while (lastIndex > firstIndex)
        {
            if (reducedString[firstIndex] != reducedString[lastIndex])
            {
                return false;
            }

            firstIndex++;
            lastIndex--;
        }

        return true;
    }
}