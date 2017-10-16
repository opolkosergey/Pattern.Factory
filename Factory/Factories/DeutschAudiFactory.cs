using Factory.Cars;
using Factory.PartsFactory;

namespace Factory.Factories
{
    public class DeutschAudiFactory : AudiFactory
    {
        public override Car CreateCar(string type)
        {
            PartsCarFactory partsCarFactory = new DeutschPartsCarFactory();

            switch (type)
            {
                case "DeutschAudiA4": return new DeutschAudiA4(partsCarFactory); 
                case "DeutschAudiA6": return new DeutschAudiA6(partsCarFactory); 
                case "DeutschAudiA7": return new DeutschAudiA7(partsCarFactory); 
                case "DeutschAudiTT": return new DeutschAudiTT(partsCarFactory); 
            }

            return null;
        }
    }
}
