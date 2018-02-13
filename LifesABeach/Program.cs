using System;

namespace LifesABeach
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your eye color?");
            string userInput = Console.ReadLine();//input of user


            BeachLocations person = new BeachLocations();//instantiating a new BeachLocation object
            Console.Write("You are going to ");
            person.Beaches(person.Color(userInput));//Allowing the 2 methods to talk


        }
    }
}
