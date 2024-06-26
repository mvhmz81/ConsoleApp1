using System;
using System.Reflection.Metadata.Ecma335;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();// declare a new car in memory and then create an instance of car to upload to memory
            //setting properties
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            Console.WriteLine("{0},{1},{2},{3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            decimal value2 = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value2);
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
            Console.ReadLine();
        }
        private static decimal DetermineMarketValue(Car car) // name of Class = Car and car is object property car could have easily been myCar
        {
            decimal carValue = 100.0M;
            return carValue;
        }
    }


    //define a simple car class
    class Car  // bucket to contain all data on car
    {
        public string Make { get; set; }
        //string Make { get; set; }: This defines a property named Make of type string. The { get; set; } part indicates that this property has both a getter and a setter, allowing it to be read and modified.
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue() 
        {
            decimal carValue;

            if (Year > 1990)
                carValue = 10000;
            else 
                carValue = 2000;
            return carValue;
        }


    }

}

