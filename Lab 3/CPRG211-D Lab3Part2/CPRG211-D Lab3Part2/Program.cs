using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211_D_Lab3Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dog object a name: ");
            string dogObject = Console.ReadLine();
            
            Console.WriteLine("Enter Dog colour: ");
            string dogColour = Console.ReadLine();
            
            Console.WriteLine("Enter Dog height: ");
            string dogHeight =Console.ReadLine();
            
            Console.WriteLine("Enter Dog age: ");
            string dogAgeString = Console.ReadLine();
            int dogAge = Convert.ToInt32(dogAgeString);

            Dog dog = new Dog(dogObject,dogColour,dogHeight,dogAge);

            Console.WriteLine(dog.FormList());
            Console.WriteLine(dog.Cry());
            dog.Eat();

            Console.WriteLine("Enter Cat object a name: ");
            string catObject = Console.ReadLine();

            Console.WriteLine("Enter Cat colour: ");
            string catColour = Console.ReadLine();

            Console.WriteLine("Enter Cat height: ");
            string catHeight = Console.ReadLine();

            Console.WriteLine("Enter Cat age: ");
            string catAgeString = Console.ReadLine();
            int catAge = Convert.ToInt32(dogAgeString);

            Cat cat = new Cat(catObject, catColour, catHeight, catAge);

            Console.WriteLine(cat.FormList());
            Console.WriteLine(cat.Cry());
            cat.Eat();

           List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

        }
    }
}
