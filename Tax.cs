using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class Tax : Dog
    {
        //Klass med arv från Dog
        public Tax(string name, string sound, int age) : base(name, sound, age)
        {
        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} is Barking");
        }
        //Unik metod för denna klass
        public void Hunting()
        {
            Console.WriteLine($"{Name} is hunting");
        }
    }
}
