using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CPRG211_D_Lab3Part2
{
    internal interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        string Height { get; set; }
        int Age { get; set; }

       
   
        void Eat();
        string Cry();
        string FormList();




    }
}
