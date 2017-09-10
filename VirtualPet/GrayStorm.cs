using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class GrayStorm
    {
        private int currentHungerLevel;
        private int maxHungerLevel;
        private int currentThirstLevel;
        private int maxThirstLevel;
        private int currentWasteLevel;
        private int maxWasteLevel;
        private int currentSleepLevel;
        private int maxSleepLevel;
        //private int currentBathroomLevel;
        //private int maxBathroomLevel;

        public int CurrentHungerLevel
        {
            get { return this.currentHungerLevel; }
        }
        public int MaxHungerLevel
        {
            get { return this.maxHungerLevel; }
        }
        public int CurrentThirstLevel
        {
            get { return this.currentThirstLevel; }
        }
        public int MaxThirstLevel
        {
            get { return this.maxThirstLevel; }
        }
        public int CurrentWasteLevel
        {
            get { return this.currentWasteLevel; }
        }
        public int MaxWasteLevel
        {
            get { return this.maxWasteLevel; }
        }
        public int CurrentSleepLevel
        {
            get { return this.currentSleepLevel; }
        }
        public int MaxSleepLevel
        {
            get { return this.maxSleepLevel; }
        }
        //public int CurrentBathroomLevel
        //{
        //    get { return this.currentBathroomLevel; }
        //}
        //public int MaxBathroomLevel
        //{
        //    get { return this.maxBathroomLevel; }
        //}

        public GrayStorm()
        {
            this.currentHungerLevel = 5;
            this.maxHungerLevel = 5;
            this.currentThirstLevel = 5;
            this.maxThirstLevel = 5;
            this.currentWasteLevel = 5;
            this.maxWasteLevel = 5;
            this.currentSleepLevel = 5;
            this.maxSleepLevel = 5;
        }

        public GrayStorm(int currentHungerLevel, int currentThirstLevel, int currentWasteLevel, int currentSleepLevel)
        {
            this.currentHungerLevel = 10;            
            this.currentThirstLevel = 10;            
            this.currentWasteLevel = 10;            
            this.currentSleepLevel = 15;
            //this.currentBathroomLevel = 15;
            
        }
        public GrayStorm(double maxHungerLevel, double maxThirstLevel, double maxWasteLevel, double maxSleeplevel)
        {
            this.maxHungerLevel = 50;
            this.maxThirstLevel = 50;
            this.maxWasteLevel = 50;
            this.maxSleepLevel = 50;
            //this.maxBathroomLevel = 25;
        }

        

        public void ChampionEater()
        {
            if (this.currentHungerLevel > 19|| this.CurrentThirstLevel > 22 || this.currentSleepLevel > 22 || this.currentWasteLevel < 2)
            {
                Console.WriteLine("I really have more pressing needs than to eat right now!!!!");
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
            }


            else
            {
                this.currentHungerLevel += 10;
                this.currentThirstLevel += 1;
                this.currentWasteLevel -= 1;
                this.currentSleepLevel += 1;
                Console.WriteLine("This is some tasty river salmon");
                Console.WriteLine();
                GrayStorm storm2 = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
                GrayStorm addingAttributes = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);

            }
        }

        public void CatChaser()
        {
            if(this.currentHungerLevel < 4 || this.currentThirstLevel < 4 || this.currentWasteLevel < 3 || this.currentSleepLevel < 6)
            {
                Console.WriteLine("Chasing Kats is fun but now is not the time for that!!!");
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
            }

            else
            {
                this.currentHungerLevel -= 1;
                this.currentThirstLevel -= 1;
                this.currentWasteLevel -= 1;
                this.currentSleepLevel -= 5;
                Console.WriteLine("This is tiring chasing these kats, but it's so fun!!!!!");
                Console.WriteLine();
                GrayStorm storm2 = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
                GrayStorm addingAttributes = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);

            }
        }

        public void SleepyTime()
        {
            if(this.currentThirstLevel < 4 || this.currentSleepLevel > 19 || this.currentHungerLevel < 4 || this.currentWasteLevel < 3)
            {
                Console.WriteLine("Sleep at a time like this?? I think not!!!!");
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
            }

            else
            {
                this.currentHungerLevel -= 1;
                this.currentWasteLevel -= 1;
                this.currentSleepLevel += 9;
                this.currentThirstLevel -= 1;
                Console.WriteLine("Your bed sure does look comfortable right now!!!");
                Console.WriteLine();
                GrayStorm storm2 = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
                GrayStorm addingAttributes = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);

            }
        }

        public void BathRoomBreak()
        {
            if (this.currentThirstLevel < 3 || this.currentHungerLevel < 3 || this.currentWasteLevel > 19 || this.currentSleepLevel < 3)
            {
                Console.WriteLine("No need to go outside at this time!!!!");
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
            }

            else
            {
                this.currentHungerLevel -= 1;
                this.currentWasteLevel += 10;
                this.currentSleepLevel -= 1;
                this.currentThirstLevel -= 1;
                Console.WriteLine("Talk about relieving!!!");
                Console.WriteLine();
                GrayStorm storm2 = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
                GrayStorm addingAttributes = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);
            }
        }

        public void ThirstLevel()
        {
            if (this.currentThirstLevel > 19 || this.currentWasteLevel < 3 || this.currentHungerLevel < 3 || this.currentSleepLevel < 3)
            {
                Console.WriteLine("I don't feel like drinking right now!");
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
            }

            else
            {
                this.currentHungerLevel -= 1;
                this.currentWasteLevel -= 1;
                this.currentSleepLevel -= 1;
                this.currentThirstLevel += 10;
                Console.WriteLine("That was some tasty H2O!!!");
                Console.WriteLine();
                GrayStorm storm2 = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);
                Console.WriteLine("Hunger Level: " + currentHungerLevel);
                Console.WriteLine("Thirst Level: " + currentThirstLevel);
                Console.WriteLine("Waste Level: " + currentWasteLevel);
                Console.WriteLine("Sleep Level: " + currentSleepLevel);
                Console.WriteLine();
                GrayStorm addingAttributes = new GrayStorm(currentHungerLevel, currentThirstLevel, currentWasteLevel, currentSleepLevel);
            }
        }

    }
}
