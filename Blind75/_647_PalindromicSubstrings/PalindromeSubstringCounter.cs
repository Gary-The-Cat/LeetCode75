using System.Security.Authentication.ExtendedProtection;

namespace _647_PalindromicSubstrings;

public class PalindromeSubstringCounter
{
    public static int GetPalindromeCount(string s)
    {
        var count = 0;
        
        for (var i = 0; i < s.Length; i++)
        {
            count += GetPalindromeCountCenteredOn(s, i, i);
        }
        
        return count;
    }
    
    private static int GetPalindromeCountCenteredOn(string s, int left, int right)
    {
        var count = 0;
        var increment = 1;
        var currentIndices = 0;
        int leftptr = left;
        int rightPrt = right;
        
        while(leftptr >= 0 && rightPrt < s.Length)
        {
            if(s[leftptr] == s[rightPrt])
            {
                count++;
                currentIndices += increment;
                leftptr = left + -currentIndices /  2;
                rightPrt = right + (currentIndices + 1) / 2;
            }
            else
            {
                if (increment == 2)
                {
                    break;
                }
                
                currentIndices += 1;
                
                leftptr = left + -currentIndices /  2;
                rightPrt = right + (currentIndices + 1) / 2;
                
                increment = 2;
            }
        }
        
        return count;
    }
}