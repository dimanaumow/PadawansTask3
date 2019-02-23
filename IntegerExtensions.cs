using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {

            if (a == 0 && b == 0)
            {
                throw new DivideByZeroException();
            }

            a = Math.Abs(a);
            b = Math.Abs(b);

            if (b == 0)
            {
                return a;
            }

            else
            {
                return Gcd(b, a % b);
            }
        }
    }
}
