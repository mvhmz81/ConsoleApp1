namespace UnderstandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int number1 = 4; 
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23; can be written like this*/

            /*int[] numbers = new int[5] ; //tells that in array there are 5 elements
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 24;

            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();*/

            int[] numbers = new int[] {4, 8, 15, 16, 23, 42};

            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            for (int i = 0; i < names.Length; i++) 
                  { Console.WriteLine(names[i]); }
                    Console.ReadLine();
            foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                Console.ReadLine();
            //try to change order of character in string
            string zig = "You can get what you want out of life" +
                "if you help enough other people get what they want.";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char c in charArray)
            { 
                Console.Write(c); 
            }   
            Console.ReadLine();
        }
    }
}
