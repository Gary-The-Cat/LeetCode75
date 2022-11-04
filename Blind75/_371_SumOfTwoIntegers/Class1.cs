namespace _371_SumOfTwoIntegers;

public static class IntegerMath
{
    public static int Sum(int a, int b)
    {
        int output = 0;
        bool carry = false;
        uint maskSource = 1;
        
        for (int i = 0; i < 32; i++)
        {
            var mask = maskSource << i;
            var aBit = (a & mask) > 0;
            var bBit = (b & mask) > 0;
            
            var bit = GeneratedDigit(aBit, bBit, carry) ? 1 : 0;
            carry = GeneratedCarry(aBit, bBit, carry);

            output |= bit << i;
            
        }

        return output;
    }

    private static bool GeneratedCarry(bool a, bool b, bool carry) =>
        (a && b || a && carry || b && carry);

    private static bool GeneratedDigit(bool a, bool b, bool carry) => a ^ b ^ carry;
}