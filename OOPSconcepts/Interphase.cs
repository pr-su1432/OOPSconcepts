using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSconcepts
{
    
        // Interface
        interface IAnimal
        {
            void AnimalSound(); // interface method (does not have a body)
        }

    //Cow "implements" the IAnimal interface
    class Cow : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The Cow says: baa baaa");
        }

        void IAnimal.AnimalSound()
        {
            throw new NotImplementedException();
        }
    }
    
    

    
}
