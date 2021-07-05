using System;

namespace UC_4_repeatTillPosition100
{
    class UC_4_repeatTillPosition100
    {
        public const int maxPosition = 100;
        public const int samePosition = 0;
        public const int forward = 1;
        public const int backward = 2;
        public static void repeatTillPosition100()
        {
            Console.WriteLine("-------------------------------------");             //For separation

            //Variables
            int currentPosition = 1;

            //Computation
            while (currentPosition <= maxPosition)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("You got " + dice + " in dice roll.");

                Random random1 = new Random();
                int options = random1.Next(0, 3);

                if (options == samePosition)
                {
                    Console.WriteLine("You Got No Option Stay in the Same Place.");
                }
                else if (options == forward)
                {
                    currentPosition = currentPosition + dice;
                    Console.WriteLine("You Got Ladder Your Moving Forward by " + dice + " numbers.");
                }
                else if (options == backward)
                {
                    currentPosition = currentPosition - dice;
                    Console.WriteLine("You Got Snakebite Your Moving Backward by " + dice + " numbers.");
                }
                if (currentPosition >= 100)
                {
                    Console.WriteLine("Congratulations You Won the Game Your at 100 position :)");
                    break;
                }
                else if (currentPosition <= 0)
                {
                    Console.WriteLine("You lost the Game Your at 0 position. Restarting the Game :(");
                    currentPosition = currentPosition - currentPosition;
                }
                Console.WriteLine("Your current Position is: " + currentPosition);
                Console.WriteLine("-------------------------------------");                 //For separation
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WELCOME TO SNAKE AND LADDER GAME :)");
            Console.WriteLine("Single Player Game is started Your at position 0.");
            UC_4_repeatTillPosition100.repeatTillPosition100();
            Console.ReadKey();
        }
    }
    
}
