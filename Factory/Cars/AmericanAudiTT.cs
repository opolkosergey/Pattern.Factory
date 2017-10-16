using Factory.PartsFactory;

namespace Factory.Cars
{
    public class AmericanAudiTT : Car
    {
        public AmericanAudiTT(PartsCarFactory factory)
        {
            Name = "AmericanAudiTT";
            Body = "Cabriolet";
            _factory = factory;
        }
    }
}
