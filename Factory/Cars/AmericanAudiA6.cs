using Factory.PartsFactory;

namespace Factory.Cars
{
    public class AmericanAudiA6 : Car
    {
        public AmericanAudiA6(PartsCarFactory factory)
        {
            Name = "AmericanAudiA6";
            Body = "Avant";
            _factory = factory;
        }
    }
}
