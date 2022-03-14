using System;

namespace HarmonicNumber
{
    class HarmonicNumber
    {

        static float sum(float n)
        {
            // Base condition
            if (n < 2)
                return 1;

            else
                return 1 / n + (sum(n - 1));
        }

        // Driven Code
        public static void Main()
        {
            Console.WriteLine(sum(8));
            Console.WriteLine(sum(10));
        }
    }
}