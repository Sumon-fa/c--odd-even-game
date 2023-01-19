using System;
using System.Runtime.CompilerServices;

namespace OddEven
{
    class Program
    {

        static void Main(string[] args)
        {
            int round = 0;
            string numberType;

            int player1Score = 0;
            int player2Score = 0;


            Console.WriteLine("\t\t\t\t Odd-Even Number Game!");
            Console.WriteLine("\t\t\t\t Total 5 round, Win or Loss!");
            Console.WriteLine("Please Write players name.");
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();

            string player1ChoosenNumberType;


            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 100);
                if (randomNumber % 2 == 0)
                {
                    numberType = "even";
                }
                else
                {
                    numberType = "odd";
                }


                if (i % 2 == 0)
                {
                    round++;
                    Console.WriteLine("\t Round " + round);
                    Console.WriteLine($"{player1}'s Score {player1Score}");
                    Console.WriteLine($"{player2}'s Score {player2Score}");
                    Console.WriteLine($"\t\t\t Please {player1} write your numbertype -");
                    player1ChoosenNumberType = Console.ReadLine();
                    if (player1ChoosenNumberType == "odd" || player1ChoosenNumberType == "even")
                    {
                        if (player1ChoosenNumberType == numberType)
                        {
                            player1Score++;
                            Console.WriteLine($"Machine generated number {randomNumber}");
                            Console.WriteLine($"Machine generated number's type {numberType}");
                            Console.WriteLine($"{player1} win at round {round}.");

                        }
                        else
                        {
                            player2Score++;
                            Console.WriteLine($"Machine generated number {randomNumber}");
                            Console.WriteLine($"Machine generated number's type {numberType}");
                            Console.WriteLine($"{player2} win at round {round}.");

                        }


                    }
                    else
                    {
                        Console.WriteLine("Error! Please write odd or even.");
                        i--;
                        round--;
                    }
                }
                else
                {
                    round++;
                    Console.WriteLine("\t Round " + round);
                    Console.WriteLine($"{player2}'s Score {player2Score}");
                    Console.WriteLine($"{player1}'s Score {player1Score}");
                    Console.WriteLine($"\t\t\t Please {player2} write your numbertype -");
                    string player2ChoosenNumberType = Console.ReadLine();
                    if (player2ChoosenNumberType == "odd" || player2ChoosenNumberType == "even")
                    {
                        if (player2ChoosenNumberType == numberType)
                        {
                            player2Score++;
                            Console.WriteLine($"Machine generated number {randomNumber}");
                            Console.WriteLine($"Machine generated number's type {numberType}");
                            Console.WriteLine($"{player2} win at round {round}.");

                        }
                        else
                        {
                            player1Score++;
                            Console.WriteLine($"Machine generated number {randomNumber}");
                            Console.WriteLine($"Machine generated number's type {numberType}");
                            Console.WriteLine($"{player1} win at round {round}.");

                        }

                    }
                    else
                    {
                        Console.WriteLine("Error! Please write odd or even.");
                        i--;
                        round--;
                    }

                }
            }
            Console.WriteLine($"{player1}'s Score {player1Score}");
            Console.WriteLine($"{player2}'s Score {player2Score}");
            if (player1Score > player2Score)
            {
                Console.WriteLine($"Congratulation {player1}! You won 2000 euro.");
            }
            else if (player2Score > player1Score)
            {
                Console.WriteLine($"Congratulation {player2}! You won 2000 euro.");
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}