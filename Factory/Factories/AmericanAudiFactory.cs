using Factory.Cars;
using Factory.PartsFactory;

namespace Factory.Factories
{
    class AmericanAudiFactory : AudiFactory
    {
        public override Car CreateCar(string type)
        {
            PartsCarFactory factory = new AmericanPartsCarFactory();

            switch (type)
            {
                case "AmericanAudiA4": return new AmericanAudiA4(factory); 
                case "AmericanAudiA6": return new AmericanAudiA6(factory); 
                case "AmericanAudiA7": return new AmericanAudiA7(factory); 
                case "AmericanAudiTT": return new AmericanAudiTT(factory); 
            }
            return null;
        }
    }
}
