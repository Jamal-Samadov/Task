using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTask
{
    public class Vehicle
    {
        public string brand;
        public string model;
        public string color;
        public int maxSpeed;


        public Vehicle()
        {

        }


        public Vehicle(string Brand, string Model)
        {
            brand = "Last";
            model = "Tesla";

        }

        public Vehicle(string Brand, string Model, string Color, int MaxSpeed)
        {
            brand = Brand;
            model = Model;
            color = Color;
            maxSpeed = MaxSpeed;    
        }




        public string Info()
        {
            return $"{brand} {model}";
        }
    }
}
