using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Scissors_Paper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int botWins = 0;
            int humanWins = 0;

        again:
            Console.WriteLine("rock, paper, scissors. Choose one: ");
            string choice = Console.ReadLine();

            Random random = new Random();
            int botChoice = random.Next(1, 4);

            switch (botChoice)
            {
                //rock
                case 1:
                    if (choice.ToLower() == "rock")
                    {
                        Console.WriteLine("it's a tie");
                    }
                    else if (choice.ToLower()== "paper")
                    {
                        Console.WriteLine("You won");
                        humanWins++;
                        if (humanWins == 3)
                        {
                            Console.WriteLine($"You won with a score of {humanWins}. Game ended. Bot {botWins}");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bot wins");
                        botWins++;
                        if(botWins == 3)
                        {
                            Console.WriteLine($"Bot won with a score of {botWins}. Game ended. You {humanWins}");
                            Console.ReadKey();
                            break;
                        }
                    }
                    Console.WriteLine("Wanna play again? Yes/No");
                    string yesNo = Console.ReadLine();

                    if (yesNo.ToLower() == "yes")
                    {
                        Console.Clear();
                        goto again;
                    }
                    else
                    {
                        Console.WriteLine("Game ended,press any key");
                        Console.ReadKey();
                    }
                    break;
                    //paper
                case 2:
                    if (choice.ToLower() == "paper")
                    {
                        Console.WriteLine("it's a tie");
                    }
                    else if (choice.ToLower() == "rock")
                    {
                        Console.WriteLine("Bot won");
                        botWins++;
                        if (botWins == 3)
                        {
                            Console.WriteLine($"Bot won with a score of {botWins}. Game ended. You {humanWins}");
                            Console.ReadKey();
                            break;
                        }
                    }
                    Console.WriteLine("Wanna play again? Yes/No");
                    yesNo = Console.ReadLine();

                    if (yesNo.ToLower() == "yes")
                    {
                        Console.Clear();
                        goto again;
                    }
                    else
                    {
                        Console.WriteLine("Game ended,press any key");
                        Console.ReadKey();
                    }
                    break;
                //scissors
                case 3:
                    if (choice.ToLower() == "scissors")
                    {
                        Console.WriteLine("it's a tie");
                    }
                    else if (choice.ToLower() == "paper")
                    {
                        Console.WriteLine("Bot won");
                        botWins++;
                        if (botWins == 3)
                        {
                            Console.WriteLine($"Bot won with a score of {botWins}. Game ended. You {humanWins}");
                            Console.ReadKey();
                            break;
                        }
                    }
                    Console.WriteLine("Wanna play again? Yes/No");
                    yesNo = Console.ReadLine();

                    if (yesNo.ToLower() == "yes")
                    {
                        Console.Clear();
                        goto again;
                    }
                    else
                    {
                        Console.WriteLine("Game ended,press any key");
                        Console.ReadKey();
                    }
                    break;
            }
        }
    }
}
