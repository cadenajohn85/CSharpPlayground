using System;
namespace CSharpPlayground
{
    public class SquareEveryDigit
    {
        public static int SquareDigits(int n)
        {
            string output = "";
            foreach (char digit in n.ToString())
            {
                output += int.Parse(digit.ToString()) * int.Parse(digit.ToString());
            }
            return int.Parse(output);
        }
    }
}
