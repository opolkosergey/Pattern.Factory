using Factory.PartsFactory;

namespace Factory.Cars
{
    public class AmericanAudiA7 : Car
    {
        public AmericanAudiA7(PartsCarFactory factory)
        {
            Name = "AmericanAudiA7";
            Body = "Coupe";
            _factory = factory;
        }
    }
}
