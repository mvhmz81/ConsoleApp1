using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//variable = bucket of info but need to decalare size with a label
            int x;
            int y;//declaration

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();*/

            Console.WriteLine("What is your name ?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //string myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName +" "+ myLastName +".");
            Console.ReadLine();
            
        }
    }
}
