namespace Board_Game
{

    //Version 2: Players board position control
    internal class Program
    {
        static void Main(string[] args)
        {

            const int finishline = 30;


            while (true)
            {
                int playerPosition = 0;
                bool gameisrunning = true;

                while (gameisrunning)
                {

                    MenuDisplay();

                    int diceNumber = RollingTheDice();

                    DiceNumber(diceNumber);

                    playerPosition += diceNumber;

                    if (playerPosition >= finishline)
                    {
                        Console.WriteLine("Congratulations, you crossed the finish line!");
                    
                        gameisrunning = false;
                    
                    }

                    else
                        Console.WriteLine($"Player position is: {playerPosition} of {finishline}");

                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();
                
                }

                string continueOption = MenuDisplayContinue();

                if (continueOption != "Y")
                    break;
            }
        }

        static void MenuDisplay()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Board Game");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Press ENTER to roll the dice");
            Console.ReadLine();

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
