using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class GrayStorm
    {
        private string akaName;
        private int hungerLevel;
        private int thirstLevel;
        private int wasteLevel;
        private int sleepLevel;

        public string AKAName
        {
            get { return this.akaName; }
            set { this.akaName = value; }
        }

        public int HungerLevel
        {
            get { return this.hungerLevel; }
        }
        public int ThirstLevel
        {
            get { return this.thirstLevel; }
        }
        public int WasteLevel
        {
            get { return this.wasteLevel; }
        }

        public GrayStorm()
        {
            this.akaName = "FightingWolf";
            this.hungerLevel = 5;
            this.thirstLevel = 5;
            this.wasteLevel = 5;
            this.sleepLevel = 5;
        }

        public GrayStorm(string akaName)
        {
            this.akaName = akaName;
            this.hungerLevel = 20;
            this.thirstLevel = 20;
            this.wasteLevel = 20;
            this.sleepLevel = 15;
        }
        public GrayStorm(int hungerLevel, int thirstLevel, int wasteLevel, int sleepLevel)
        {
            this.hungerLevel = hungerLevel;
            this.thirstLevel = thirstLevel;
            this.wasteLevel = wasteLevel;
            this.sleepLevel = sleepLevel;
        }


        public void ChampionEater()
        {
            if (this.hungerLevel > 23)
            {
                Console.WriteLine("I have no room to hold more food!!! I need to go outside!!!!");
            }

            else
            {
                this.hungerLevel += 3;
                this.thirstLevel += 2;
                this.wasteLevel += 5;
                this.sleepLevel += 1;
                Console.WriteLine("This is some tasty salmon");
            }
        }

        public void CatChaser()
        {
            if(this.hungerLevel < 2)
            {
                Console.WriteLine("I have no energy to chase these kitty kats, I need food and water..and possibly a nap!!!");
            }

            else
            {
                this.hungerLevel -= 4;
                this.thirstLevel -= 2;
                this.wasteLevel += 1;
                this.sleepLevel -= 5;
                Console.WriteLine("This is tiring chasing these kats, but I can't stop");
            }
        }

        public void SleepyTime()
        {
            if(this.thirstLevel < 1)
            {
                Console.WriteLine("I'm having a hard time sleeping with this dry mouth, need a drink first");
            }

            else
            {
                this.hungerLevel -= 3;
                this.wasteLevel += 2;
                this.sleepLevel -= 5;
                this.thirstLevel -= 4;
                Console.WriteLine("I'm ready to have some fun!!!");
            }
        }


        
    }
}
