using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical7
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch, rs;
            int r;
            while (true)
            {
                Console.WriteLine("1. rs to dollar");
                Console.WriteLine("2. rs to euro");
                Console.WriteLine("3. rs to pound");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter value...");
                ch = Console.ReadLine();
                char c = Char.Parse(ch);
               
                //int c = Int32.Parse(ch);
                switch (c)
                {
                    case '1':
                        {
                            Console.WriteLine("Enter value...");
                            rs = Console.ReadLine();
                            r = Int32.Parse(rs);
                            Dollar(r);
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Enter value...");
                            rs = Console.ReadLine();
                            r = Int32.Parse(rs);
                            euro(r);
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("Enter value...");
                            rs = Console.ReadLine();
                            r = Int32.Parse(rs);
                            pound(r);
                            break;
                        }
                   
                    case '4':
                        goto outer;
                        break;
                    default:
                        Console.WriteLine("Try again...");
                        goto outer;
                        break;
                }
            }
        outer: Console.Read();

        }

        private static void pound(int r)
        {
            float d;
            d = (float)0.011 * r;
          
            Console.WriteLine("value is : " + d);
        }

        private static void euro(int r)
        {
            float d;
            d = (float)0.013 * r;
            Console.WriteLine("value is : " + d);
        }

        private static void Dollar(int r)
        {
            float d;
            d = (float)0.014 * r;
            Console.WriteLine("value is : " + d);
        }
    }
}
