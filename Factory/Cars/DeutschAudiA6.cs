using System;
using Factory.PartsFactory;

namespace Factory.Cars
{
    public class DeutschAudiA6 : Car
    {
        public DeutschAudiA6(PartsCarFactory factory)
        {
            Name = "DeutschAudiTT";
            Body = "Cabriolet";
            _factory = factory;
        }
    }
}
