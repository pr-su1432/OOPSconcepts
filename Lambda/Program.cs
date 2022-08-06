using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lambda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<PersonClass> listPersonInCity = new List<PersonClass>();
            AddRecords(listPersonInCity);
            RetrieveRecordsLessThanForty(listPersonInCity);
        }

        private static void AddRecords(List<PersonClass> listPersonInCity)
        {
            listPersonInCity.Add(new PersonClass(101, "Prasanna", 24));
            listPersonInCity.Add(new PersonClass(101, "arjun", 26));
            listPersonInCity.Add(new PersonClass(101, "Sravanthi", 16));
        }

        private static void RetrieveRecordsLessThanForty(List<PersonClass> listPersonInCity)
        {
            foreach (PersonClass person in listPersonInCity.FindAll(e => (e.Age <= 26)).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }


    }


}