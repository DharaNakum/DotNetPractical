using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classpractical
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
namespace Inheritance
{
    abstract class  salesman
    {
        string firstname;
        string lastname;
        private int myVar;
        public salesman(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        /*public int MyProperty1
        {
            get { return myVar; }
            set { if(myVar<100)
            {myVar = value;
            }
            else
            return mtVar}
        }*/
        //Myproperty = 33; //is equvelent to my Var = 33; 
        /*public int MyProperty { get; set; }*/
        public string FullName
        {
            get { return firstname + " " + lastname;  }
        }
        int MyProperty;
        //Console.WriteLine("njm ");
           // public int MyProperty { get; private set; }
    }
}
