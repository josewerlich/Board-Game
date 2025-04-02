namespace Board_Game
{

    //Version 4: Special events - extra positions, back positions, 6 roll the dice again. 
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

                    if (playerPosition == 11 || playerPosition == 16 || playerPosition == 21)
                    {

                        Console.WriteLine("Bonus: Advance 3 houses");
                        Console.WriteLine();

                        playerPosition += 3;

                        Console.WriteLine($"Player position is: {playerPosition} of {finishline}");
                    }
                    else if (playerPosition == 13 || playerPosition == 19 || playerPosition == 22)
                    {
                        Console.WriteLine("Bad luck: Go back 2 houses");
                        Console.WriteLine();

                        playerPosition += -2;

                        Console.WriteLine($"Player position is: {playerPosition} of {finishline}");
                    }

                    if (playerDiceNumber == 6)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Roll the dice again, press R");
                        ConsoleKeyInfo rollDiceAgain = Console.ReadKey(true);
                        if (rollDiceAgain.Key == ConsoleKey.R)
                        {

                            Console.Write("Rolling the extra dice: ");
                           
                            playerDiceNumber = RollingTheDice();
                            Console.WriteLine(playerDiceNumber);
           
                            playerPosition += playerDiceNumber;

                            if (playerPosition == 11 || playerPosition == 16 || playerPosition == 21)
                            {

                                Console.WriteLine("Bonus: Advance 3 houses ");
                                Console.WriteLine();

                                playerPosition += 3;
                            }
                            else if (playerPosition == 13 || playerPosition == 19 || playerPosition == 22)
                            {
                                Console.WriteLine("Bad luck: Go back 2 houses");
                                Console.WriteLine();

                                playerPosition += -2;
                            }
                        }
                    }

                    Console.WriteLine("Press ENTER to continue.");
                    Console.ReadLine();

                    //CPU playing
                    MenuDisplay("CPU");

                    int cpuDiceNumber = RollingTheDice();

                    DiceNumber(cpuDiceNumber);

                    cpuPosition += cpuDiceNumber;

                    if (cpuPosition >= finishline)
                    {
                        Console.WriteLine("Oh no!! CPU crossed the finish line!");

                        gameisrunning = false;
                        continue;

                    }

                    else
                        Console.WriteLine($"CPU position is: {cpuPosition} of {finishline}");

                    if (cpuPosition == 11 || cpuPosition == 16 || cpuPosition == 21)
                    {

                        Console.WriteLine("Bonus: Advance 3 houses");
                        Console.WriteLine();

                        cpuPosition += 3;

                        Console.WriteLine($"Player position is: {cpuPosition} of {finishline}");
                    }
                    else if (cpuPosition == 13 || cpuPosition == 19 || cpuPosition == 22)
                    {
                        Console.WriteLine("Bad luck: Go back 2 houses");
                        Console.WriteLine();

                        cpuPosition += -2;

                        Console.WriteLine($"Player position is: {cpuPosition} of {finishline}");
                    }

                    if (cpuDiceNumber == 6)
                    {
                        
                            Console.WriteLine("Rolling the extra dice: ");
                            

                            cpuDiceNumber = RollingTheDice();
                            Console.WriteLine(cpuDiceNumber);
                            

                            cpuPosition += cpuDiceNumber;

                            if (cpuPosition == 11 || cpuPosition == 16 || cpuPosition == 21)
                            {

                                Console.WriteLine("Bonus: Advance 3 houses ");
                                Console.WriteLine();

                                cpuPosition += 3;
                            }
                            else if (cpuPosition == 13 || cpuPosition == 19 || cpuPosition == 22)
                            {
                                Console.WriteLine("Bad luck: Go back 2 houses");
                                Console.WriteLine();

                                cpuPosition += -2;
                            }
                        
                    }

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
