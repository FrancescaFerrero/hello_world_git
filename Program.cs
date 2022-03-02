using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: test for null.
        if (args.Length >= 1)
        {
            string name = args[0];
            Console.Write("Hello, " + name);
        }
        else
        {
            Console.WriteLine("Hello World");
        }
    }
}