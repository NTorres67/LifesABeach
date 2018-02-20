using System;
using System.Collections.Generic;
using System.Text;

namespace LifesABeach
{
    public class BeachLocations : Travel
    {

        // look at possibly using "base.nnnn();"
        //{
        //int value = base.SwitchValue();
        //GetBeach(value);


        //Method
        public void Beaches(int number)  
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Punaluu Black Sands Beach, Hawaii");
                    break;
                case 2:
                    Console.WriteLine("North Shore, Hawaii");
                    break;
                case 3:
                    Console.WriteLine("Green Sands Beach, Hawaii");
                    break;
                case 4:
                    Console.WriteLine("Lake Erie, Ohio");
                    break;
            }
        }
    }
}
