namespace Board_Game
{

    //Version 3: Add CPU as a player 
    internal class Program
    {
        static void Main(string[] args)
        {

            const int finishline = 30;


            while (true)
            {
                int playerPosition = 0;
                int cpuPosition = 0;

                bool gameisrunning = true;

                while (gameisrunning)
                {

                    //Player playing
                    MenuDisplay("Player");

                    int playerDiceNumber = RollingTheDice();

                    DiceNumber(playerDiceNumber);

                    playerPosition += playerDiceNumber;

                    if (playerPosition >= finishline)
                    {
                        Console.WriteLine("Congratulations, you crossed the finish line!");
                    
                        gameisrunning = false;
                        continue;
                    
                    }

                    else
                        Console.WriteLine($"Player position is: {playerPosition} of {finishline}");

                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();

                    //CPU playing
                    MenuDisplay("CPU");

                    int cpuDiceNumber = RollingTheDice();

                    DiceNumber(cpuDiceNumber);

                    cpuPosition += cpuDiceNumber;

                    if (playerPosition >= finishline)
                    {
                        Console.WriteLine("Oh no!! CPU crossed the finish line!");

                        gameisrunning = false;
                        continue;

                    }

                    else
                        Console.WriteLine($"CPU position is: {cpuPosition} of {finishline}");

                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();

                }

                string continueOption = MenuDisplayContinue();

                if (continueOption != "Y")
                    break;
            }
        }

        static void MenuDisplay(string whoIsPlaying)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Board Game");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{whoIsPlaying}'s turn");

            

            if (whoIsPlaying != "CPU")
            {
                Console.WriteLine("Press ENTER to roll the dice");
                Console.ReadLine();
            }
        }

        static int RollingTheDice()
        {
            Random diceNumberGeneration = new Random();

            int diceNumber = diceNumberGeneration.Next(1, 7);

            return diceNumber;
        }
        static void DiceNumber(int diceNumber)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Dice Number is: {diceNumber}");
            Console.WriteLine("----------------------------------");

          
        }

        static string MenuDisplayContinue()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Do you want to continue? (Y/N) ");

            string continueOption = Console.ReadLine()!.ToUpper();

            return continueOption;
        }
    }
}
