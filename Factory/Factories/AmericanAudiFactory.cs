using Factory.Cars;
using Factory.PartsFactory;

namespace Factory.Factories
{
    public class AmericanAudiFactory : AudiFactory
    {
        public override Car CreateCar(string type)
        {
            PartsCarFactory partsCarFactory = new AmericanPartsCarFactory();

            switch (type)
            {
                case "AmericanAudiA4": return new AmericanAudiA4(partsCarFactory); 
                case "AmericanAudiA6": return new AmericanAudiA6(partsCarFactory); 
                case "AmericanAudiA7": return new AmericanAudiA7(partsCarFactory); 
                case "AmericanAudiTT": return new AmericanAudiTT(partsCarFactory); 
            }

            return null;
        }
    }
}
