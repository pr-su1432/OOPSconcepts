using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class PersonClass
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public PersonClass(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;

        }
    }
}
