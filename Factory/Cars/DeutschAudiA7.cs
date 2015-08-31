using System;
using Factory.PartsFactory;

namespace Factory.Cars
{
    public class DeutschAudiA7 : Car
    {
        public DeutschAudiA7(PartsCarFactory factory)
        {
            Name = "DeutschAudiTT";
            Body = "Cabriolet";
            _factory = factory;
        }
    }
}
