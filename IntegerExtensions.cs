using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp; 
            }

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
