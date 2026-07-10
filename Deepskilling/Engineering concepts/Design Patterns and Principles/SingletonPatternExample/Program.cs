using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Application Started");
            logger2.Log("User Logged In");

            if (logger1 == logger2)
            {
                Console.WriteLine("Singleton Pattern implemented successfully.");
                Console.WriteLine("Only one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("Singleton Pattern implementation failed.");
            }
        }
    }
}