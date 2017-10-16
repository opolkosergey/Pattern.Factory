using System;
using Factory.Factories;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AudiFactory factory = new DeutschAudiFactory();

            factory.GetCar("DeutschAudiTT");

            Console.ReadLine();
        }
    }
}
