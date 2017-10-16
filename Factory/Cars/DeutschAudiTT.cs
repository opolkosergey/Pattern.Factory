using Factory.PartsFactory;

namespace Factory.Cars
{
    public class DeutschAudiTT : Car
    {
        public DeutschAudiTT(PartsCarFactory factory)
        {
            Name = "DeutschAudiTT";
            Body = "Cabriolet";
            _factory = factory;
        }
    }
}
