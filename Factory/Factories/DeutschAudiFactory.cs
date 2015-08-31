using Factory.Cars;
using Factory.PartsFactory;

namespace Factory.Factories
{
    class DeutschAudiFactory : AudiFactory
    {
        PartsCarFactory factory = new DeutschPartsCarFactory();
        public override Car CreateCar(string type)
        {
            switch (type)
            {
                case "DeutschAudiA4": return new DeutschAudiA4(factory); 
                case "DeutschAudiA6": return new DeutschAudiA6(factory); 
                case "DeutschAudiA7": return new DeutschAudiA7(factory); 
                case "DeutschAudiTT": return new DeutschAudiTT(factory); 
            }
            return null;
        }
    }
}
