﻿using System;

namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu) // == true
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {   
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3") 
            { 
                return false;
            }
            else 
            {
                Console.WriteLine("That is not an option please try again");
                return true;
            }

        }
        private static void PrintNumbers()
    {
            Console.Clear();
            Console.WriteLine("Print Numbers");
            Console.WriteLine("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result)
            {
                Console.WriteLine(counter++);
                Console.WriteLine("-");
                //counter++;
            }
        Console.ReadLine();
    }

       private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11); //(Min, max)
            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess the number between 1 and 10: ");
                string result = Console.ReadLine();

                if (result == randomNumber.ToString())
                {
                    guesses++;
                    incorrect = false;
                }
                else
                    Console.WriteLine("Wrong!, Try again.");
            } while (incorrect);
            Console.WriteLine("Correct!!! It took you {0} guesses.", guesses); //places guesses value in {}
            Console.ReadLine();
        }
    } 

}

