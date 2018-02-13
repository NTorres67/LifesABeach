using System;
using System.Collections.Generic;
using System.Text;

namespace LifesABeach
{
    public class Travel
    {
        //fields
        private string eyeColor;

        //Properties
        public string EyeColor { get; set; }

        //Constructor
        public Travel()
        {
            //default
        }

        public Travel(string eyeColor)
        {
            EyeColor = eyeColor;
        }

        //Method
        public int Color(string eyeColor)
        {
            int value = 0;
            switch (eyeColor.ToUpper())
            {

                case "BLUE":
                    value = 1;
                    break;

                case "GREEN":
                    value = 2;
                    break;

                case "BROWN":
                    value = 3;
                    break;

                default:
                    value = 4;
                    break;
            }
            return value;

        }
    }
}
