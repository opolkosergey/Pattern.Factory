using System;
using Factory.PartsFactory;

namespace Factory.Cars
{
    public class AmericanAudiA4 : Car
    {
        public AmericanAudiA4(PartsCarFactory factory)
        {
            Name = "AmericanAudiA4";
            Body = "Avant";
            _factory = factory;
        }
    }
}
