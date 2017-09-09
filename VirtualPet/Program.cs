using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        private static int currentHungerLevel;
        private static int currentSleepLevel;
        private static int currentThirstLevel;
        private static int currentWasteLevel;
        private static int num;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is GrayStorm");
            Console.WriteLine();
            GrayStorm storm2 = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);
            Console.WriteLine("Hunger Level: " + storm2.CurrentHungerLevel);
            Console.WriteLine("Thirst Level: " + storm2.CurrentThirstLevel);
            Console.WriteLine("Waste Level: " + storm2.CurrentWasteLevel);
            Console.WriteLine("Sleep Level: " + storm2.CurrentSleepLevel);
            Console.WriteLine();
            GrayStorm addingAttributes = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);

            do
            {
                Console.WriteLine("Select the number of your choice: ");
                Console.WriteLine("1: Feed GrayStorm");
                Console.WriteLine("2: Let GrayStorm play");
                Console.WriteLine("3: Put GrayStorm to bed");
                Console.WriteLine("4: Let GrayStorm out for bathroom break");
                Console.WriteLine("5: Give a drink to GrayStorm");
                Console.WriteLine("6: Quit");
                Console.Write("Enter the number of your choice: ");
                var userChoice = Console.ReadLine();
                Console.WriteLine();
                if (!Int32.TryParse(userChoice, out num)) continue;

                if (userChoice == "6")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Choice = " + userChoice);

                if (userChoice == "1")
                {
                    storm2.ChampionEater();
                    //Some code that will allow me to enter info on some game
                    // it will then display the menu again after all questions are answered.
                }
                else if (userChoice == "2")
                {
                    storm2.CatChaser();
                }
                else if (userChoice == "3")
                {
                    storm2.SleepyTime();
                }
                else if (userChoice == "4")
                {
                    storm2.BathRoomBreak();
                }
                else if (userChoice == "5")
                {
                    storm2.ThirstLevel();
                }

            } while (true);





        }
    }
}
