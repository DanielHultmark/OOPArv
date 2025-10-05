using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Hästklass som avropar Animal som basklass
    internal class Horse : Animal
    {
        //Konstruktor för Horse
        public Horse(string name, string sound, int age) : base (name, sound, age)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} is neighing!");
        }
    }
}
