using System;

namespace Factory.Parts
{
    public class Diesel : Engine
    {
        public Diesel()
        {
            Console.WriteLine("Fuel type is diesel");
        }
    }
}
