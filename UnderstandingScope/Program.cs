namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = ""; // Declare 'j' in the scope of the Main method

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString(); // Assign 'i' to 'j' as a string
                k = i.ToString();
                Console.WriteLine(i);
                if (i ==9) 
                {
                    string l = i.ToString();
                    Console.WriteLine("Bonjouir" + l); //this is within context
                }
                //Console.WriteLine(l);//l is outside the context  because l is declared within the curly braces
                Console.WriteLine("hello" + i); // Print "hello" followed by the current value of 'i'
                Console.WriteLine("Bye" + j); // Print "Bye" followed by the current value of 'j'
                Console.WriteLine("Ohmy" + k);
            }

            Console.WriteLine("Outside of the for: " + j); // Print the value of 'j' after the loop
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();// accessible as within class
            Car myCar = new Car();  
            myCar.DoSomething();

            Console.ReadLine(); // Wait for user input before closing the console window
        }
        static void HelperMethod()
        {
            Console.WriteLine("Value of K from the HelperMethod():" + k);
        }
    }
     class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod()); //prints 
            //helperMethod(); //calls but doesnt do anything with it 
        }
        private string helperMethod() 
        {
            return "Hello World!";
        }
    }
}
