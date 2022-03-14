namespace PowerOfTwo
{
    class Power
    {
        static bool isPowerOfTwo(int n)
        {
            return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2))))
                  == (int)(Math.Floor(((Math.Log(n) / Math.Log(2)))));
        }

        public static void Main()
        {
            if (isPowerOfTwo(31))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            if (isPowerOfTwo(64))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}