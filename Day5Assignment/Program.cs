namespace FlipCoin
{
    class FlipCoin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 for Flip Coin and print percentage of Heads and Tails");
            int Problem = Convert.ToInt32(Console.ReadLine());

            switch (Problem)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
        class Flip_Percentage
        {

            public Flip_Percentage()
            {
                int Heads = 0;
                int Tails = 0;

                Console.Write("Enter the number of times you want to flip the coin: ");
                int Number_of_Flips = Convert.ToInt32(Console.ReadLine());

                while (Number_of_Flips <= 0)
                {
                    Console.WriteLine("Invalid input, please input a number greater than 0.");
                    Console.Write("Please enter again: ");
                    Number_of_Flips = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < Number_of_Flips; i++)
                {
                    Random flip = new Random();
                    int HoT = flip.Next(0, 2);

                    if (HoT < 0.5)
                    {
                        Heads++;
                    }
                    else
                    {
                        Tails++;
                    }
                }

                float Heads_Percent = (float)Heads * 100 / Number_of_Flips;
                float Tails_Percent = (float)Tails * 100 / Number_of_Flips;

                Console.WriteLine(Heads_Percent + "% of the times the result was heads.");
                Console.WriteLine(Tails_Percent + "% of the times the result was tails.");
            }
        }
       

    }
}
