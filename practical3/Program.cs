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
            string country;
            do
            {
                Console.WriteLine("Please enter your name...");
                name = Console.ReadLine();
            } while (!Regex.IsMatch(name,"^[a-zA-z]+$"));
            Console.WriteLine("Please enter your country name...");
            country = Console.ReadLine();

            Console.WriteLine("Hello " + name + " from " + country);
            Console.Read();
        }
    }
}