using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string Country;
            do
            {
                Console.WriteLine("Please enter your name...");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));
            do
            {
                Console.WriteLine("Please enter your country name...");
                Country = Console.ReadLine();
            } while (!Regex.IsMatch(Country, "^[a-zA-Z]+$"));

            Console.WriteLine("Hello " + name + " from " + Country);
            Console.Read();
        }
    }
}
