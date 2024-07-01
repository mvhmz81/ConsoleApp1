using System;
using System.Timers;
using System.Threading.Tasks;
using Timer = System.Timers.Timer; // had to be added as Timer is referenced in two systems

namespace TimerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the timer
            Timer myTimer = new Timer(2000); // 2000 milliseconds = 2 seconds

            // Subscribe to the Elapsed event
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;

            // Start the timer
            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;
            // Keep the program running to listen for timer events
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // Output the time of the event
            Console.WriteLine("Elapsed: {0:HH:mm:ss:fff}", e.SignalTime);
        }
        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor= ConsoleColor.Red;
            // Output the time of the event
            Console.WriteLine("Elapsed1: {0:HH:mm:ss:fff}", e.SignalTime);
        }
    }
}
