namespace BasicCoreProgram
{
    internal class Factor
    {

        public void Factors()
        {
            Console.Write("Enter the Numbe: ");
            int Num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} Prime Factors is = ", Num);

            for (int i = 2; i * i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}