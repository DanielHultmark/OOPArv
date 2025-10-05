using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Hundklass som även avropar Animal som basklass
    internal class Dog : Animal
    {
        //konstruktor för Dog
        public Dog(string name, string sound, int age) : base(name, sound, age)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} is Barking");
        }
        
    }
}
