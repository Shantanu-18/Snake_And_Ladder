using System;

namespace UC_7_twoPlayers
{
    class UC_7_twoPlayers
    {
        public const int maxPosition = 100;
        public const int samePosition = 0;
        public const int forward = 1;
        public const int backward = 2;
        public static void twoPlayers()
        {
            Console.WriteLine("-------------------------------------");             //For separation

            //Variables
            int player1Position = 0;
            int player2Position = 0;
            int newPositionPlayer1 = 0;
            int newPositionPlayer2 = 0;
            int numOfDiceRoll = 0;

            //Computation
            while (player1Position <= maxPosition && player2Position <= maxPosition)
            {
                //Random numbers generation
                Random random = new Random();
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int options1 = random.Next(0, 3);
                int options2 = random.Next(0, 3);

                Console.WriteLine("Player 1 got " + dice1 + " in dice roll.");
                Console.WriteLine("Player 2 got " + dice2 + " in dice roll.");


                
                newPositionPlayer1 = player1Position + dice1;
                newPositionPlayer2 = player2Position + dice2;
                numOfDiceRoll++;


                if (newPositionPlayer1 == maxPosition)
                {
                    Console.WriteLine("Congratulations Player 1 Won the Game :)");
                    Console.WriteLine("Dice was rolled " + numOfDiceRoll + " times.");
                    break;
                }

                else if (newPositionPlayer1 > maxPosition)
                {
                    Console.WriteLine("Player 1 Got No Option stay in same Position.");
                    Console.WriteLine("Player 2 current Position is: " + player1Position);
                    Console.WriteLine("-------------------------------------");                     //For Separation
                    continue;
                }

                if (newPositionPlayer2 == maxPosition)
                {
                    Console.WriteLine("Congratulations Player 2 Won the Game :)");
                    Console.WriteLine("Dice was rolled " + numOfDiceRoll + " times.");
                    break;
                }

                else if (newPositionPlayer2 > maxPosition)
                {
                    Console.WriteLine("Player 2 Got No Option stay in same Position.");
                    Console.WriteLine("Player 2 current Position is: " + player2Position);
                    Console.WriteLine("-------------------------------------");                     //For Separation
                    continue;
                }
                
                //For Player 1
                if (options1 == samePosition)
                {
                    Console.WriteLine("Player 1 Got No Option Stay in the Same Place.");
                }
                else if (options1 == forward)
                {
                    player1Position += dice1;
                    Console.WriteLine("Player 1 Got Ladder Your Moving Forward by " + dice1 + " numbers.");
                }
                else if (options1 == backward)
                {
                    player1Position -= dice1;
                    Console.WriteLine("Player 1 Got Snakebite Your Moving Backward by " + dice1 + " numbers.");
                }

                //For Player 2
                if (options2 == samePosition)
                {
                    Console.WriteLine("Player 2 Got No Option Stay in the Same Place.");
                }
                else if (options2 == forward)
                {
                    player2Position += dice2;
                    Console.WriteLine("Player 2 Got Ladder Your Moving Forward by " + dice2 + " numbers.");
                }
                else if (options2 == backward)
                {
                    player2Position -= dice2;
                    Console.WriteLine("Player 2 Got Snakebite Your Moving Backward by " + dice2 + " numbers.");
                }

                if (player1Position <= 0)
                {
                    Console.WriteLine("Player 1 lost the Game. Player 1 is at 0 position. Restarting the Game for player 1 :(");
                    player1Position = player1Position - player1Position;
                }
                if (player2Position <= 0)
                {
                    Console.WriteLine("Player 2 lost the Game. Player 2 is at 0 position. Restarting the Game for player 2 :(");
                    player2Position = player2Position - player2Position;
                }
                Console.WriteLine("Player 1 current Position is: " + player1Position);
                Console.WriteLine("Player 2 current Position is: " + player2Position);
                Console.WriteLine("Dice was rolled " + numOfDiceRoll + " times.");
                Console.WriteLine("-------------------------------------");                 //For separation
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WELCOME TO SNAKE AND LADDER GAME :)");
            Console.WriteLine("Two Player Game is started Both players is at position 0.");
            UC_7_twoPlayers.twoPlayers();
            Console.ReadKey();
        }
    }
}
