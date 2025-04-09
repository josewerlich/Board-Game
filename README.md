# Board Game - README

Welcome to the Board Game! This is a simple console-based board game where you compete against a CPU by rolling dice to move along a board, with various events that may help or hinder your progress.

## Features: 
- Players and the CPU take turns rolling a 6-sided dice.
- Special events occur when you land on specific positions:
  - **Bonus**: Advance 3 spaces.
  - **Bad Luck**: Go back 2 spaces.
- If you roll a **6**, you get to roll the dice again.
- The first player to cross the finish line (position 30) wins the game.
- The game supports replaying after each round.


## How to Play:
1. **Starting the Game**: The game starts by rolling a dice. The player takes their turn first, followed by the CPU.
2. **Rolling the Dice**: On your turn, press `Enter` to roll the dice.
3. **Special Events**:
   - If you land on positions **11, 16, or 21**, you will receive a bonus and move ahead by 3 positions.
   - If you land on positions **13, 19, or 22**, you will be penalized and move back by 2 positions.
   - If you roll a **6**, you get to roll again by pressing `R` after your first roll.
4. **Winning**: The game ends when either the player or CPU crosses the finish line (position 30). The first to do so wins.

## Key Methods:
- **`RollingTheDice()`**: Generates a random number between 1 and 6 to simulate the dice roll.
- **`MenuDisplay(string whoIsPlaying)`**: Displays the menu for the player or CPU's turn.
- **`DiceNumber(int diceNumber)`**: Displays the rolled dice number.
- **`MenuDisplayContinue()`**: Asks if you want to continue playing after the round ends.

## How to Run:
1. Clone the repository or download the code.
2. Open the project in Visual Studio or your preferred C# development environment.
3. Build and run the project.
4. Play the game directly in the console.

## Example Gameplay:
```
----------------------------------
Board Game
----------------------------------
Player's turn
Press ENTER to roll the dice
----------------------------------
Dice Number is: 4
----------------------------------
Player position is: 4 of 30
Press ENTER to continue.

----------------------------------
Board Game
----------------------------------
CPU's turn
----------------------------------
Dice Number is: 3
----------------------------------
CPU position is: 3 of 30
Press ENTER to continue.

Do you want to continue? (Y/N)
```



Enjoy playing the game! Feel free to contribute by creating pull requests or reporting any issues.