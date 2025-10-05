using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Klass för katt som avropar Animal som basklass
    internal class Cat : Animal
    {
        //Konstruktor för Cat
        public Cat(string name, string sound, int age) : base (name,sound, age)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} is meowing!");
        }
    }
}
