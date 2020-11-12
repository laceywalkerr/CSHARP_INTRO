//in javascript, this would be the import
using System;

namespace Intro
{
    public class Program
    { //below is a method, the method name is Main
        // "(string[] args)" are the parameters
        public static void Main(string[] args)
        { //Console.Write(); is the new Console.Log();
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! I'm glad to meet you.");
        }
    }
}