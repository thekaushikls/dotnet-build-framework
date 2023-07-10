using System;

namespace HelloWorldLibrary
{
    public static class HelloWorld
    {
        public static void Greet(string name)
        {
            if (name.ToLower() == "kaushik")
            {
                Console.WriteLine($"Welcome back {name}!\n");
            }
            else
            {
                Console.WriteLine($"Hello {name}\n");
            }
        }
    }
}
