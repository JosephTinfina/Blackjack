using Blackjack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Computer computer = new Computer();            
            bool gamerounds = true;
            int bet = 0;
            int Credit = 1000;
            Console.WriteLine("Welcome to Gamble your money AWAY BlackJack");
            Console.WriteLine($"Your Credit is £{Credit}");

            while (gamerounds)
            {
                Console.WriteLine($"How much would you like to bid out of your £{Credit}");
                try
                {
                    bet = int.Parse(Console.ReadLine());
                    if (bet > Credit)
                    {
                        Console.WriteLine($"You are betting over your full credit amount, setting bid to £{Credit}");
                        bet = Credit;
                    }
                    else
                    {
                        Credit = Credit - bet;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a number -  I'm setting your bet to your whole balance");
                    bet = Credit;
                    Credit -= bet;
                }

                Console.WriteLine($"Your bet is {bet}");

                if (computer.startGame())
                {
                    Console.WriteLine("You have won.");
                    Credit = Credit + (bet * 2);
                }
                else
                {
                    Console.WriteLine("You have lost.");
                }
                Console.WriteLine($"Your new credit is £{Credit}");
                Console.WriteLine("Play again, you could win your money back (y/n)");
                if (Console.ReadLine() == "n")
                {
                    gamerounds = false;
                }
            }

            Console.WriteLine("The addiction only just started...");
            Console.WriteLine($"Your end Credit was £{Credit}");
            Console.ReadLine();
        }
    }
}

