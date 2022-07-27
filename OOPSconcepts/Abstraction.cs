using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSconcepts
{
        abstract class Animal
        {
            // Abstract method (does not have a body)
            public abstract void AnimalSound();
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Derived class (inherit from Animal)
        class Pig : Animal
        {
            public override void AnimalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }
    
}
