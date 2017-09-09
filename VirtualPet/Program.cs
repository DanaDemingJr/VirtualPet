using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            GrayStorm AKA = new GrayStorm();
            AKA.AKAName = "FightingWolf";
            Console.WriteLine(AKA.AKAName);

            GrayStorm hungerLevel = new GrayStorm();
            Console.WriteLine(hungerLevel);


        }
    }
}
