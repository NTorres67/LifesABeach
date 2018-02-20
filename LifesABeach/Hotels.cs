using System;
using System.Collections.Generic;
using System.Text;

namespace LifesABeach
{
    public class Hotels : Travel
    {
        // Method
        
        public void Sleep(double size)
        {
            switch (size)
            {
                case 11:
                    {
                        Console.WriteLine("Sea Mountain Resort.");
                        break;
                    }

                case 12:
                    {
                        Console.WriteLine("Mauna Kea Beach Hotel");
                        break;
                    }

                case 13:
                    {
                        Console.WriteLine("Hilo Hawaiian Hotel");
                        break;
                    }

                case 14:
                    {
                        Console.WriteLine("Days Inn Lakewood");
                        break;
                    }

                case 21:
                    {
                        Console.WriteLine("Pahala Plantation Cottages");
                        break;
                    }

                case 22:
                    {
                        Console.WriteLine("Waikaloa Beach Hotel");
                        break;
                    }

                case 23:
                    {
                        Console.WriteLine("Uncle Billy's Kona");
                        break;
                    }

                case 24:
                    {
                        Console.WriteLine("Travelodge Lakewood");
                        break;
                    }



            }

        }



    }
}
