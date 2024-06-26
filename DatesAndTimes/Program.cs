using System;

namespace DatesAndTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());// will take country and local and present dates and time as per local
            //Console.WriteLine(myValue.ToShortDateString()); //just date
            //Console.WriteLine(myValue.ToShortTimeString()); // just time
            //Console.WriteLine(myValue.ToLongDateString()); //long format
            //Console.WriteLine(myValue.ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString()); // allows us to manipulate date
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString()); // allows to remove aswell by using negative
            //Console.WriteLine(myValue.Month);//do not need () as .Month is a property of DateTime and returns the month int
            //if you want the month in letters you
            //Console.WriteLine(myValue.ToString("MMM"));

            //DateTime myBirthday = new DateTime(1991, 06, 09); //YYYY, MMM, DD
            //Console.WriteLine(myBirthday.ToLongDateString());

            DateTime myBirthday = DateTime.Parse("12/07/1969");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday); //TimeSpan represents a time interval.
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
