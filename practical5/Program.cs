using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter infix: ");
            string Infix = Console.ReadLine();
            
            String postfix = InfixtoPostfix(Infix);
            Console.WriteLine("postfixed value is " + postfix);
           
            
           
            Console.Read();
        }

        private static string InfixtoPrefix(string Infix)
        {
            string temp = InfixtoPostfix(Infix);     
            return temp;
        }

        private static string InfixtoPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            String postfix = "";
            Char ch;
            for(int i=0;i<infix.Length;i++)
            {
                ch = infix[i];
                if(isObject(ch))
                {
                    if(stack.Count==0)
                    {
                        stack.Push(ch);
                    }
                    else if(priority(ch)>priority(stack.Peek()))
                    {
                        stack.Push(ch);
                    }
                    else
                    {
                        postfix += ch;
                    }
                }
                else if(ch == '(')
                {
                    stack.Push(ch);
         
                }
                else if (ch == ')')
                {
                    if(!(ch == '('))
                    {
                        postfix += stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    postfix += ch;
                }  
            }
            while(stack.Count!=0)
                postfix += stack.Pop();
            return postfix;
        }

        private static int priority(char ch)
        {
            
                switch (ch)
                {
                    case '+':
                        return 1;
                    case '-':
                        return 1;
                    case '*':
                        return 2;
                    case '/':
                        return 2;
                    case '^':
                        return 3;
                }
                return 0;
        }

        private static bool isObject(char ch)
        {
            if (ch=='+' || ch == '-' || ch == '*' || ch == '/')
                return true;
            else
                return false;
        }
    }
}
