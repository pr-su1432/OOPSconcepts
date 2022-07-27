using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSconcepts
{
    public class Polymorphisam
    {
        // Base class (parent)
        
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }

        class Pig : Polymorphisam  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Polymorphisam  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

        
    }
}
