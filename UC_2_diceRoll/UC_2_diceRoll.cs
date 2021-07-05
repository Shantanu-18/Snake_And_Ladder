using System;

namespace UC_2_diceRoll
{
    class UC_2_diceRoll
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int diceRoll = random.Next(0, 7);
            Console.WriteLine("You got " + diceRoll+ " in dice roll.");
        }
    }
}
