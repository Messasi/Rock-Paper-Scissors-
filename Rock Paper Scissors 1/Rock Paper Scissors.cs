using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exception_Handlingg
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //get the user guess
            string UserGuess = GetUserGuess();

           //Computer guess
            string AiGuess = GetAiguess();

            
            Console.WriteLine($"Your choice: {UserGuess}  AiChoice: {AiGuess}");
            
            //declearing the winner
            string winner = (GetWinner(UserGuess, AiGuess));

            //printing out the winner
            Console.WriteLine(winner);
            Console.ReadKey();

        }
        

        static string GetUserGuess()
        {
            //asking the user to enter their guess
            string UserGuess;

            do
            {   //vlaidation for the user guess
                Console.WriteLine("Enter your guess can only be rock , paper or sissors");
                UserGuess = Console.ReadLine();

                if (UserGuess.ToLower() != "rock" && UserGuess.ToLower() != "paper" && UserGuess.ToLower() != "scissors" )
                {
                    Console.WriteLine("Ivalid entry try again");
                }
            } while (UserGuess.ToLower() != "rock" && UserGuess.ToLower() != "paper" && UserGuess.ToLower() != "scissors");

            return UserGuess;
        }

        static string GetWinner(string UserGuess, string AiGuess) 
        {
            //for the different choices
            if (UserGuess == AiGuess)
            {
                return "its a tie";
            }
            if ((AiGuess == "rock" && UserGuess == "scissors") ||
                (AiGuess == "paper" && UserGuess == "rock") ||
                (AiGuess == "scissors" && UserGuess == "paper")
               )
            {
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Red;
                return "\nyou lost!";
            }
            else
            {
                //timing the output
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Green;
                return "\nYou win";

            }
        }

        static string GetAiguess() 
        {
            //choosing a random choice
            string[] choices = { "Rock", "paper", "sissors" };

            string AiGuess = choices[new Random().Next(choices.Length)];

            return AiGuess;
        } 
    }
}
