using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_D_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dog object a name: ");
            string dogObject = Console.ReadLine();
            Console.WriteLine("Enter Dog colour: ");
            string dogColour = Console.ReadLine();
            Console.WriteLine("Enter Dog age: ");
            string dogAgeString = Console.ReadLine();
            int dogAge = Convert.ToInt32(dogAgeString);

            Animal dog = new Dog(dogObject, dogColour, dogAge);

            Console.WriteLine(dog.FormListDog());

            dog.Eat();
            Console.WriteLine("Enter Cat object a name: ");
            string catObject = Console.ReadLine();
            Console.WriteLine("Enter Cat colour: ");
            string catColour = Console.ReadLine();
            Console.WriteLine("Enter Cat age: ");
            string catAgeString = Console.ReadLine();
            int catAge = Convert.ToInt32(dogAgeString);

            Animal cat = new Cat( catObject, catColour, catAge);

            Console.WriteLine(cat.FormListCat());

            cat.Eat();

        }
    }
}
