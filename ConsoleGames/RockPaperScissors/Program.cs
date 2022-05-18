using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = string.Empty;
            string computer = string.Empty;

            string title = "This is the game \"Rock Paper Scissors\".";
            string instructions = "Please choose: [r]ock, [p]aper or [s]cissors.";
            string qiuting = "If you wish to stop playing type \"stop\".";

            Console.SetCursorPosition((Console.WindowHeight / 2) + (instructions.Length / 2) + 2, 0);
            Console.WriteLine(title);

            Console.SetCursorPosition((Console.WindowHeight / 2) + (instructions.Length / 2), 1);
            Console.WriteLine(instructions);

            Console.SetCursorPosition((Console.WindowHeight / 2) + (instructions.Length / 2) + 2, 2);
            Console.WriteLine(qiuting);

            player = Console.ReadLine();

            while (player != "stop")
            {
                switch (player)
                {
                    case "rock":
                    case "r":
                        player = "Rock";
                        break;
                    case "paper":
                    case "p":
                        player = "Paper";
                        break;
                    case "scissors":
                    case "s":
                        player = "Scissors";
                        break;
                    default:
                        Console.Write("Please enter valid input:");
                        player = Console.ReadLine();
                        continue;
                }

                computer = GetComputerChoice();

                if (player == computer)
                {
                    Console.WriteLine($"Player choose {player}.");
                    Console.WriteLine($"Computer choose {computer}");
                    Console.WriteLine("DRAW! :|");
                }
                else if (player == "Rock")
                {
                    if (computer == "Paper")
                    {
                        Console.WriteLine($"Player choose {player}.");
                        Console.WriteLine($"Computer choose {computer}");
                        Console.WriteLine("Computer WINS! :(");
                    }
                    else
                    {
                        Console.WriteLine($"Player choose {player}.");
                        Console.WriteLine($"Computer choose {computer}");
                        Console.WriteLine("Player WINS! :)");
                    }
                }
                else if(player == "Paper")
                {
                    if (computer == "Rock")
                    {
                        Console.WriteLine($"Player choose {player}.");
                        Console.WriteLine($"Computer choose {computer}");
                        Console.WriteLine("Player WINS! :)");
                    }
                    else
                    {
                        Console.WriteLine($"Player choose {player}.");
                        Console.WriteLine($"Computer choose {computer}");
                        Console.WriteLine("Computer WINS! :(");
                    }
                }
                else if (player == "Scissors")
                {
                    if (computer == "Rock")
                    {
                        Console.WriteLine($"Player choose {player}.");
                        Console.WriteLine($"Computer choose {computer}");
                        Console.WriteLine("Computer WINS! :(");
                    }
                    else
                    {
                        Console.WriteLine($"Player choose {player}.");
                        Console.WriteLine($"Computer choose {computer}");
                        Console.WriteLine("Player WINS! :)");
                    }
                }

                Console.WriteLine("\n\n Player picks ->");
                player = Console.ReadLine();
            }

            string goodbeyText = "Thanks for playing! :)";

            Console.SetCursorPosition((Console.WindowHeight / 2) + (goodbeyText.Length / 2), Console.CursorTop);
            Console.WriteLine(goodbeyText);
        }

        static string GetComputerChoice()
        {
            string choice = string.Empty;

            Random number = new Random();

            int randomNum = number.Next(1, 4);

            switch (randomNum)
            {
                case 1: 
                    choice = "Rock";
                    break;
                case 2:
                    choice = "Paper";
                    break;
                case 3:
                    choice = "Scissors";
                    break;
            }

            return choice;
        }
    }
}
