using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1();//this will call pattern1
            Console.WriteLine("");
            pattern2();//this will call pattern2
            Console.WriteLine("");
            pattern3();//this will call pattern3
            Console.Read();
        }

        private static void pattern3()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        private static void pattern2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        private static void pattern1()
        {
            //throw new NotImplementedException();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }

}
