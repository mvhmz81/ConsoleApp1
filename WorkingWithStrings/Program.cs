using System;
using System.Text;


namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";// here \ is used to allow the character " TO BE SEEN IN THE STRING
            //string myString = "what if i need a \nnew line ?"; // \n gives a new line
            //string myString = "Go to your c:\\ drive"; // issue is we need the \ in the string  so you can add an extra \
            //string myString = @"Go to your c:\ drive"; //or add at @ sign
            //string myString = string.Format("{0} = {1}", "First", "Second");
            //string myString = string.Format("{0:C}", 123.45);//:C means i want you to format like currency
            //string myString = string.Format("{0:N}", 1234567890); // :N formats numbers with commas to show easier format
            //string myString = string.Format("Percentage: {0:P} ", .123); //:P percentage
            //string myString = string.Format("Phone Number:{0:(####) ########}", 01234567890);//# allows you to state visual format of numbers 
            //string myString = " That summer we took threes accross the board ";
            //myString = myString.Substring(6, 14); // pulls from index 6 and the next 14 characters
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14); //removes from 6th index plus 14 characters
            /*myString = String.Format("Length before: {0} -- Length after: {1}", 
                myString.Length, myString.Trim().Length); //removes white space before and after sentence and compares length*/
            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            Console.WriteLine(myString);
            Console.ReadLine();

            really big code for simple task*/

            //so if you want to conatenate alot of strings or build use this 

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++) 
            {
                myString.Append("--");//append in more efficient prevents need for temp files 
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
