using Factory.PartsFactory;

namespace Factory.Cars
{
    public class DeutschAudiA4 : Car
    {
        public DeutschAudiA4(PartsCarFactory factory)
        {
            Name = "DeutschAudiTT";
            Body = "Cabriolet";
            _factory = factory;
        }
    }
}
