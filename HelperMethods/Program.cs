namespace HelperMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The Name Game!");
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("In what city were you born?");
            string city = Console.ReadLine();
            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = " ";

            foreach (char c in firstNameArray)
            {
                result += c;
            }
            result += " ";

            foreach (char c in lastNameArray)
            {
                result += c;
            }
            result += " ";

            foreach (char c in cityArray)
            {
                result += c;
            }
            result += " ";

            Console.WriteLine("Results: " + result);
            */
            /*Console.Write("Results: ");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);
            Console.ReadLine();
                         
            ////really long code and lots of repetition so if were were to 
            //create a collection and call that it would be simple and
            //more readable*/
            /*Console.Write("Results: ");
            string reversedFirstName = ReverseString(firstName);
            string reversedLastName = ReverseString(lastName);
            string reversedCity = ReverseString(city);

            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
            Console.ReadLine();*/

            DisplayResult(
                ReverseString(firstName), 
                ReverseString(lastName), 
                ReverseString(city));
            
            Console.WriteLine();
            DisplayResult(ReverseString(firstName) + " " +
                ReverseString(lastName) + " " +
                ReverseString(city));

            Console.ReadLine();
        }
        /*private static void ReverseString(string message)
        {
            //to see if it works hard code a string
            //string message = "Hello World!"; removed to make reusable
            // create an input parameter to be passed into method
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char c in messageArray)
            {
                Console.Write(c);
            }
            Console.Write(" ");
        }
        */
        private static string ReverseString(string message)
        {
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
            
        }
        private static void DisplayResult (string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                reversedFirstName,
                reversedLastName,
                reversedCity));
            
        }
        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }
    }
}
