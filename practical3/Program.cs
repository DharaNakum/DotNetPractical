using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string country;
            Console.WriteLine("Please enter your name...");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your country name...");
            country = Console.ReadLine();

            Console.WriteLine("Hello " + name + " from " + country);
            Console.Read();
        }
    }
    /*abstract class Salesman
    {
        String firstname;
        String lastname;
        Salesman(string firstname,string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        static void sell()
        {
            Console.WriteLine("your name is ");
        }
   
    }*/
}