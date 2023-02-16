using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_D_Lab3Part2
{
    internal class Cat:IAnimal
    {
        private string name;
        private string colour;
        private string height;
        private int age;

        public string Name { get => this.name; set => name = value; }
        public string Colour { get =>  this.colour; set => colour = value; }
        public string Height { get => this.height; set => height = value; }
        public int Age { get => this.age; set => age = value; }
        public Cat(string name, string colour, string height, int age)
        {
            this.name = name;
            this.colour = colour;
            this.height = height;
            this.age = age;
        }
        public string FormList()
        {
            string display =
                string.Format("Cat name: {0}", Name) + "\n" +
                string.Format("Cat colour:{0}", Colour) + "\n" +
                string.Format("Cat Height:{0}", Height) + "\n" +
                string.Format("Cat age:{0}", Age) + "\n";


            return display;
        }
        public string Cry()
        {
            return "MeoW!";
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
