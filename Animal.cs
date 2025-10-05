using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    //Dasklass för samtliga djur
    public class Animal
    {
        //Konstruktor för Animal
        public string Sound { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Origin { get; set; }
        public Animal(string name = "unknown", string sound = "unknown", int age = 0, string color = "unknown", string origin = "unknown")
        {
            Sound = sound;
            Name = name;
            Age = age;
            Color = color;
            Origin = origin;
        }
        //Metoder för Animal
        public void Eat()
        {
            Console.WriteLine($"{Name} - {Age} years old is eating!");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping!");
        }
        public void Drink()
        {
            Console.WriteLine($"{Name} is drinking!");
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }
    }
}
