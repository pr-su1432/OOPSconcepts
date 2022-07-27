using System;

namespace OOPSconcepts
{
    //class definition
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance---------------
            /* // Create a myCar object
             Car myCar = new Car();

             // Call the  method (From the Vehicle class) on the myCar object
             myCar.inheritance();

             // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
             Console.WriteLine(myCar.brand + " " + myCar.modelName);*/

            //Polymorphisam-----------
            /*  Polymorphisam myAnimal = new Polymorphisam();  // Create a Animal object
              Polymorphisam myPig = new Polymorphisam();  // Create a Pig object
              Polymorphisam myDog = new Polymorphisam();  // Create a Dog object

             myAnimal.animalSound();
             myPig.animalSound();
             myDog.animalSound();*/

            //Abstraction------------
            /* Pig myPig = new Pig(); // Create a Pig object
             myPig.AnimalSound();  // Call the abstract method
             myPig.sleep();  // Call the regular method*/

            //Interphase------------------
            /* Cow mycow = new Cow();  // Create a Pig object
             mycow.animalSound();*/

            //Exceptions----------------
            Exceptions exe = new Exceptions();
            exe.exceptions();

        }
    }  
}