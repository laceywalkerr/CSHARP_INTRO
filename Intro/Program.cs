//in javascript, this would be the import
using System;

namespace Intro
{
    public class Program

    {
        static void Taco1()
        {

        }

        static void Taco2()
        {

        }

        static void Taco3()
        {

        }

        //below is a method, the method name is Main
        // "(string[] args)" are the parameters, args is a taco
        public static void Main(string[] args)
        // void = function doesnt have a return statement and cant have a return statment 

        { //Console.Write(); is the new Console.Log();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! I'm glad to meet you.");
            Taco1();
            Taco2();
            Taco3();
        }

    }
}
// in "Console." you can choose various options to pick from
// wrench is propety
// cube is method
// run "dnignore" in terminal for a gitignore file (except my code doesnt like this and i need to find out why)