using System;
using System.Collections.Generic;
using System.Text;

namespace LifesABeach
{
    public class Travel
    {
        
        public double size = 0;

        //fields
        private string eyeColor;
        private double shoeSize;

        //Properties
        public string EyeColor { get; set; }
        public double ShoeSize { get; set; }

        //Constructor
        public Travel()
        {
            //default
        }

        public Travel(string eyeColor, double shoeSize)
        {
            this.eyeColor = eyeColor;
            this.shoeSize = shoeSize;
        }

        //Method
        public int value = 0;
        public int Color(string eyeColor)

        {
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

        

        public double Shoes(double shoeSize, int colorNum)
        {
            switch (shoeSize)
            {
                case 6.5:
                    if (colorNum == 1)
                    {
                        size = 11;
                    }
                    else if (colorNum == 2)
                    {
                        size = 12;
                    }
                    else if (colorNum == 3)
                    {
                        size = 13;
                    }
                    else if (colorNum == 4)
                    {
                        size = 14;
                    }
                    break;

                case 10.5:
                    if (colorNum == 1)
                    {
                        size = 21;
                    }
                    else if (colorNum == 2)
                    {
                        size = 22;
                    }
                    else if (colorNum == 3)
                    {
                        size = 23;
                    }
                    else if (colorNum == 4)
                    {
                        size = 24;
                    }
                    break;
            }
            return size;
        }
    }
}
