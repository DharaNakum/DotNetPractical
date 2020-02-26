using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value...");
            string number = Console.ReadLine();
            float num = float.Parse(number);
            Console.WriteLine("if you want to convert celsius to fahrenheit then press 1");
            Console.WriteLine("else press 2");
            string ch = Console.ReadLine();
            int c1 = Int32.Parse(ch);
            if (c1==1)
            {
                float f;
                f = (float)(((9 / 5) * num) + 32) / 32;
                Console.WriteLine("fahrenheit : " + f);
            }
            else
            {
                float c;
                double a = 0.55555556;
                c = (float)(((32 * num)-32)*a);
                //c = (float)((5 / 9) * ((32 * num) - 32));
                Console.WriteLine("celsius : " + c);
            }
            Console.Read();
        }
    }
}
