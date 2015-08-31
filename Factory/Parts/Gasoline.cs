using System;

namespace Factory.Parts
{
    public class Gasoline : Engine
    {
        public Gasoline()
        {
            Console.WriteLine("Fuel type is Gasoline");
        }
    }
}
