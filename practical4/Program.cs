using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch,number;
            int num;
            while (true)
            {
                Console.WriteLine("1. Decimal to Binary conversion");
                Console.WriteLine("2. Decimal to octa conversion");
                Console.WriteLine("3. Decimal to hexa conversion");
                Console.WriteLine("4. Binary to Binary conversion");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter value...");
                ch = Console.ReadLine();
                char c = Char.Parse(ch);
                //int c = Int32.Parse(ch);
               switch(c)
                {
                    case '1':
                        {
                            Console.WriteLine("Enter value...");
                            number = Console.ReadLine();
                            num = Int32.Parse(number);
                            Console.WriteLine("number: " + num);
                            binaryconv(num);
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Enter value...");
                            number = Console.ReadLine();
                            num = Int32.Parse(number);
                            Console.WriteLine("number: " + num);
                            octaconv(num);
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("Enter value...");
                            number = Console.ReadLine();
                            num = Int32.Parse(number);
                            Console.WriteLine("number: " + num);
                            hexaconv(num);
                            break;
                        }
                    case '4':
                        {
                            Console.WriteLine("Enter binary number...");
                            number = Console.ReadLine();
                            num = Int32.Parse(number);
                            Console.WriteLine("number: " + num);
                            deciconv(num);
                            break;
                        }
                    case '5':
                        goto outer;
                        break;
                    default:
                        Console.WriteLine("Try again...");
                        goto outer;
                        break;
                }
            }
           
           // string number = Console.ReadLine();
            //int num = Int32.Parse(number);
            Console.WriteLine("number: " + num);
            binaryconv(8);
            octaconv(15);
            hexaconv(10);
            deciconv(1010);
           outer : Console.Read();
        }

        private static void deciconv(int v)
        {
            int d,i=0,sum=0,s;
            while(v>0)
            {
                d = v % 10;
                v = v / 10;
                s =Power(2.0,i);
                sum = sum + (s * d);
                i++;
            }
            Console.WriteLine("your decimal value is...");
            Console.WriteLine(sum);
        }

        private static int Power(double v, int i)
        {
            int temp=1;
            while(i>0)
            {
                temp = 2 * temp;
                i--;
            }
            return temp;
        }

        private static void binaryconv(int v)
        {
            int []rem =new int[10];
            int i = 0;
            while (v>0)
            {
                rem[i] = v % 2;
                v = v / 2;
                i++;
            }
            i--;
            Console.WriteLine("your binary value is...");
            while(i>=0)
            {
                Console.WriteLine(rem[i]);
                i--;
            }
        }
        private static void octaconv(int v)
        {
            int[] rem = new int[10];
            int i = 0;
            while (v > 0)
            {
                rem[i] = v % 8;
                v = v / 8;
                i++;
            }
            Console.WriteLine("your octa value is...");
            i--;
            while (i >= 0)
            {
                Console.WriteLine(rem[i]);
                i--;
            }
        }
        private static void hexaconv(int v)
        {
            char[] rem = new char[10];
            int temp;
            int i = 0;
            while (v > 0)
            {
                temp = v % 16;
                if(temp<9)
                {
                    rem[i] = (char)(temp + 48);
                }
                else
                {
                    rem[i] = (char)(temp + 55);
                }
                v = v / 16;
                i++;
            }
            Console.WriteLine("your hexa value is...");
            i--;
            while (i >= 0)
            {
                Console.WriteLine(rem[i]);
                i--;
            }
        }

    }

}
