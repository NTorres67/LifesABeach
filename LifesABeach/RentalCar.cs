using System;
using System.Collections.Generic;
using System.Text;

namespace LifesABeach
{
    class RentalCar : Travel
    {
        int car = 0;
        int shoe = 0;

        public int Transport(double size, int number)
        {
            shoe = (int)size;
            car = (shoe + number);
            return car;
        }

        public void Ride(int car)
        {
            if ((car % 2) == 0)
            {
                Console.WriteLine("Alamo Rent a Car");
            }
            else if ((car % 3) == 0)
            {
                Console.WriteLine("Dollar Rent a Car");
            }
            else
            {
                Console.WriteLine("Avis Rent a Car");
            }
        }
        


    }
}
