using System;

namespace LifesABeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = " ";
            double userShoe = 0;

            Console.WriteLine("");
            Console.WriteLine("     _\\/_                 |                  _\\/_  ");
            Console.WriteLine("     /O\\              \\       /              //O\\");
            Console.WriteLine("      |                 .----.                 |");
            Console.WriteLine("     _|_______     --  /      \\  --     _______|__ ");
            Console.WriteLine("              `~^~^~^~^~^~^~^~^~^~^~^~`  ");
            Console.WriteLine("                 jgs");

            Console.WriteLine("Welcome to the Torres Travel Agency where vacations are an adventure.");
            Console.WriteLine("");
            Console.WriteLine("To determine where you will be going and where you will be staying, I will be asking you a few questions.");
            Console.WriteLine("");
            Console.WriteLine("What is your eye color?");
            userInput = Console.ReadLine();//input of user
            Console.WriteLine("");
            Console.WriteLine("Now, is your shoe size closer to 6.5 or 10.5?");

            userShoe = double.Parse(Console.ReadLine());
            Console.WriteLine("");



            BeachLocations person = new BeachLocations();//instantiating a new BeachLocation object

            Hotels place = new Hotels();

            RentalCar vehicle = new RentalCar();

            Console.Write("You are going to ");
            person.Beaches(person.Color(userInput));//Allowing the 2 methods to talk
            Console.Write("staying at the ");
            place.Sleep(place.Shoes(userShoe, person.Color(userInput)));
            Console.Write("driving around in a ");
            vehicle.Ride(vehicle.Transport(userShoe, person.Color(userInput)));
            Console.WriteLine("");

        }
    }
}
