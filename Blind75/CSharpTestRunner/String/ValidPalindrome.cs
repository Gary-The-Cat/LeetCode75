using _125_ValidPalindrome;

namespace TestRunner.String;

public class ValidPalindrome
{
    public class SumOfTwoIntegers
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        public void Run(string potentialPalindrome, bool isPalindrome) =>
            PalindromeValidator.IsPalindrome(potentialPalindrome).Should().Be(isPalindrome);
    }
}