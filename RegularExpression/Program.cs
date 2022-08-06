using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patterns = new Regex();
            Console.WriteLine(patterns.validatePinCode("abc123"));
            Console.WriteLine(patterns.validatePinCode("400123"));

        }

    }
}