using System.Collections;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "B2";


            Book b1 = new Book();
            b1.Author = "Rober Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";

            //ArrayLists are dynamically sized, 
            // supports, sorting removing but is not type specific

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);

            //foreach(Car car in myArrayList)
            //{
            //    Console.WriteLine(car.Make);
            //}

            //this wont work as we have a a b1 in our arrayList so we do this instead
            //List<T>  Generic type restricts to type so b1 cannot be added

            /*List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1 );  is not allowed as the list is spcific to a Car datatype

            foreach (Car car in myList ) 
            {
                Console.WriteLine(car.Model);
            }
            */

            //an alternative is a dictionary where you look up the key and the associated value
            //Dictionary<tKey, TValue> key must be unique and value can be any dataType
            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1 );
            myDictionary.Add(car2.VIN, car2 );
            Console.WriteLine(myDictionary["B2"].Make);
            */
            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };
            //object initializer syntax which doesnt need a constructor as before
            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

            //Collection Initializer with object initiaklizers
            List<Car> myList = new List<Car>();
            {
                new Car { Make = "OLdsmobile", Model = "Cutlas Supreme", VIN = "E5" };
                new Car { Make = "Nissan", Model = "Altima", VIN = "F6" };
            };
            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
    class Book
    { 
        public string Title { get; set; } 
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
