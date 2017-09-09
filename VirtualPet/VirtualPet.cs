using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        private int hungerLevel;
        private int thirstLevel;
        private int wasteLevel;

        public int  HungerLevel
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

        public VirtualPet()
        {
            this.hungerLevel = 5;
            this.thirstLevel = 5;
            this.wasteLevel = 5;
        }
    }


}
