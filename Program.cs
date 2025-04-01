namespace Board_Game
{

    //Version 1: Structure and dices simulation
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                MenuDisplay();

                int diceNumber = RollingTheDice();

                DiceNumber(diceNumber); 


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
            Console.WriteLine("Do you want to continue? (Y/N) ");

            string continueOption = Console.ReadLine()!.ToUpper();

            return continueOption;
        }
    }
}
