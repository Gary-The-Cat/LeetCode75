using _647_PalindromicSubstrings;

namespace TestRunner.String;

public class PalindromicSubstrings
{
    [Theory]
    [InlineData("abc", 3)]
    [InlineData("aaa", 6)]
    [InlineData("aba", 4)]
    public void Run(string s, int palindromeCount) =>
        PalindromeSubstringCounter.GetPalindromeCount(s).Should().Be(palindromeCount);
}