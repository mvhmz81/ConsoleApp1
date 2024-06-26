using System;
using System.IO;
using System.Net;



namespace AssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "This is what is written in our text file";
            File.WriteAllText(@"C:\Users\mzavery\source\repos\ConsoleApp1\AssembliesAndNamespaces\WriteText.txt", text); //creates a text file in the folder stated , references variable text as what will be saved

            WebClient client = new WebClient();
            string reply = client.DownloadString("https://msdn.microsoft.com");
            Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\mzavery\source\repos\ConsoleApp1\AssembliesAndNamespaces\WriteText2.txt", reply);

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
        //we can do simple searches using site:microsoft.com this makes it so the search is only in microsoft files
    }
}
