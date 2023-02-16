using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_D_Lab3
{
    internal abstract class Animal 
    {
        protected string name;
        protected string colour;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Colour
        {
            get { return this.colour; }
            set { this.colour = value; }
        }
        protected int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Animal(string name, string colour, int age)
        {
            this.name = name;
            this.colour = colour;
            this.age = age;
        }
        public string FormListDog()
        {
            string display =
                string.Format("Dog name: {0}", name) + "\n" +
                string.Format("Dog colour:{0}", colour) + "\n" +
                string.Format("Dog age:{0}", Age) + "\n";


            return display;
        }

        public string FormListCat()
        {
            string display =
                string.Format("Cat name: {0}", name) + "\n" +
                string.Format("Cat colour:{0}", colour) + "\n" +
                string.Format("Cat age:{0}", Age) + "\n";


            return display;
        }
        public abstract void Eat();

    }
}
