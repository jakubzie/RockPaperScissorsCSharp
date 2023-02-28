using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random roll = new Random();
            int userWin = 0, aiWin = 0,aiRoll;
            string[] choices = { "R", "P", "S" };
            string aiChoice, userChoice;
            bool valid,play=true;
            while (play)
            {
                aiRoll = roll.Next(choices.Length);
                aiChoice = choices[aiRoll];
                do
                {
                    Console.Write("WprowadŸ swój wybór ([R]ock / [P]aper / [S]cissors): ");
                    userChoice = Console.ReadLine().ToUpper();
                    if (userChoice == "R" || userChoice == "P" || userChoice == "S")
                    {
                        Console.WriteLine("Komputer wybra³: " + aiChoice);
                        if (aiChoice == userChoice)
                        {
                            Console.WriteLine("Remis!");
                        }
                        else if (userChoice == "R" && aiChoice == "P")
                        {
                            Console.WriteLine("Wygrywa komputer!");
                            aiWin++;
                        }
                        else if (userChoice == "R" && aiChoice == "S")
                        {
                            Console.WriteLine("Wygrywa gracz!");
                            userWin++;
                        }
                        else if (userChoice == "P" && aiChoice == "R")
                        {
                            Console.WriteLine("Wygrywa gracz!");
                            userWin++;
                        }
                        else if (userChoice == "P" && aiChoice == "S")
                        {
                            Console.WriteLine("Wygrywa komputer!");
                            aiWin++;
                        }
                        else if (userChoice == "S" && aiChoice == "R")
                        {
                            Console.WriteLine("Wygrywa komputer!");
                            aiWin++;
                        }
                        else if (userChoice == "S" && aiChoice == "P")
                        {
                            Console.WriteLine("Wygrywa gracz!");
                            userWin++;
                        }
                        Console.WriteLine();
                        valid = false;
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna figura! Spróbuj ponownie!");
                        valid = true;
                    }
                } while (valid);
                bool ask=true;
                while (ask)
                {
                    Console.Write("Czy chcesz zagraæ ponownie (Tak/Nie): ");
                    string doYouPlay;
                    doYouPlay = Console.ReadLine().ToLower();
                    if (doYouPlay.ToLower() == "tak")
                    {
                        play = true;
                        ask = false;
                    }
                    else if (doYouPlay.ToLower() == "nie")
                    {
                        play = false;
                        ask = false;
                        Console.WriteLine("Koñczymy rozgrywkê!");
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawdna odpowiedŸ! Spróbuj jeszcze raz!");
                    }
                }
            }
            Console.WriteLine("\nKomputer wygra³ " + aiWin + " razy || Gracz wygra³ " + userWin + " razy.");
            if (userWin > aiWin)
            {
                Console.WriteLine("Wygrywa gracz! Gratulujemy i dziêkujemy za rozgrywkê!");
            }
            else if (aiWin > userWin)
            {
                Console.WriteLine("Wygrywa komputer! Nie poddawaj siê, nastêpnym razem siê uda!");
            }
            else
            {
                Console.WriteLine("Remis! Co za niespodzianka ;o");
            }
            Console.ReadLine();
        }
    }
}
