using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // start::print-hello-world
            string helloWorld = CreateHelloWorld();

            Console.WriteLine(helloWorld);
            // end::print-hello-world
        }

        // start::create-hello-world
        private static string CreateHelloWorld()
        {
            string hello = "Hello";
            string world = "World";

            return $"{hello} {world}!";
        }
        // end::create-hello-world
    }
}
