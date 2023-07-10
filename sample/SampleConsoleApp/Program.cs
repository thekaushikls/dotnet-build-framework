using System;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            HelloWorldLibrary.HelloWorld.Greet(name);

            Console.ReadKey();
        }
    }
}
