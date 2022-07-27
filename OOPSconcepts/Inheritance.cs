using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSconcepts
{
    class Inheritance  // base class (parent) 
    {
        public string brand = "Maruthi Suzuki";  // Vehicle field
        public void inheritance()             // Vehicle method 
        {
            Console.WriteLine("Maruthi, Suzuki!");
        }
    }

    class Car : Inheritance  // derived class (child)
    {
        public string modelName = "Brezza";  // Car field
    }

}


