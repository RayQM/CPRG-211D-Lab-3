using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_D_Lab3
{
    internal class Dog : Animal
    {
        public Dog(string name, string colour, int age):base(name, colour, age) { }
        public override void Eat()
        {
            Console.WriteLine("Dog eat meat.");
        }
        
    }
}
