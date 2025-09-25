using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name} - {Age} years old is eating!");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping!");
        }
    }
}
