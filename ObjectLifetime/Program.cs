using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car.MyMethod();
            
            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";
            Console.WriteLine("{0},{1},{2},{3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            /*
                        Car parameterCar = new Car("Ford", "Mustang", 1981, "Blue");
                        Console.WriteLine("{0}, {1}, {2}, {3} ",
                            parameterCar.Make,
                            parameterCar.Model,
                            parameterCar.Year,
                            parameterCar.Color);

                        Car myOtherCar;
                        myOtherCar = myCar; // created a link to reference same info in myCar
                        Console.WriteLine("{0}, {1}, {2},{3}",
                            myOtherCar.Make,
                            myOtherCar.Model,
                            myOtherCar.Year,
                            myOtherCar.Color);

                        //to prove they are the same lets change the value of a variable using myOtherCar.Model
                        myOtherCar.Model = "98";
                        // then call the values of myCar
                        Console.WriteLine("{0}, myCar:{1},{2},{3}, \nmyOtherCar: {4}",
                            myCar.Make,
                            myCar.Model,
                            myCar.Year,
                            myCar.Color,
                            myOtherCar.Model); // calls both value of myOtherCar.Model and myCar.Model shows same value

                        myOtherCar.Model = "Mukti";
                        Console.WriteLine("{0}, myCar:{1},{2},{3}, \nmyOtherCar: {4}",
                            myCar.Make,
                            myCar.Model,
                            myCar.Year,
                            myCar.Color,
                            myOtherCar.Model);
                        */
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        /*public Car() //default value
        {
            //you could load from a confi file, or a database
            this.Make = "Nissan";// 'this'- keyword is optional and refers to this instance 
        }
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }*/
        public static void MyMethod()
        {
            Console.WriteLine("Called the static Method");
            Console.WriteLine();
        }
    }
    
}

