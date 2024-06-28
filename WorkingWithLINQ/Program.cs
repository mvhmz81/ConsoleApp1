using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml.Schema;

namespace WorkingWithLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() {VIN= "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2009},
                new Car() {VIN= "B1", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2010},
                new Car() {VIN= "C1", Make = "BMW", Model = "745li", StickerPrice = 75000 ,Year = 2008},
                new Car() {VIN= "D1", Make = "FORD", Model = "Escape", StickerPrice = 25000, Year = 2008},
                new Car() {VIN= "E1", Make = "BMW", Model = "551i", StickerPrice = 57000, Year = 2010}
            };

            /*//LINQ Query
            var bmws = from car in myCars
                      where car.Make == "BMW" 
                      && car.Year == 2010
                      select car;
           
            //LINQ Method to obtain results
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.VIN, car.Model);
            }
             */

            //but the above can query can be integrated with the method
            //LINQ Query+Method integrated
            var bmws = myCars.Where(c => c.Make == "BMW" && c.Year == 2010);
            foreach (var car in bmws) 
                {
                    Console.WriteLine("{0} {1}", car.VIN, car.Model);
                }
            var orderedCars = myCars.OrderBy(c => c.Year);
            foreach (var car in orderedCars)
                {
                Console.WriteLine("{0} {1} {2}", car.Year, car.VIN, car.Model);
            }

            var orderedCars1 = myCars.First(c => c.Make == "BMW");
            Console.WriteLine(orderedCars1.VIN);

            var orderedCars3 = myCars.OrderBy(c => c.Year).First(c => c.Make == "BMW");
            Console.WriteLine(orderedCars3.VIN);

            myCars.ForEach(c => Console.WriteLine("{0} {1:C}", c.VIN, c.StickerPrice));

            //join two changes
            myCars.ForEach(c => c.StickerPrice -= 3000);
            myCars.ForEach(c => Console.WriteLine("{0} {1:C}", c.VIN, c.StickerPrice));

            //bool statement
            Console.WriteLine(myCars.Exists(c => c.Model == "745li" && c.Year ==2010));

            //total sum car value
            Console.WriteLine(myCars.Sum(c => c.StickerPrice));

           //Continue 6:38



            Console.ReadLine();
            
        }
    }
    class Car
    {
        public string VIN { get; set; }
        public string Make  {get; set;}
        public string Model { get; set; }
        public int StickerPrice { get; set;}
        public int Year { get; set; }
    }
}
