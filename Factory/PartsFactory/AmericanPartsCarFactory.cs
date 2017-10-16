using Factory.Parts;

namespace Factory.PartsFactory
{
   public class AmericanPartsCarFactory : PartsCarFactory
    {
       public override Engine CreatEngine()
       {
           return new Diesel();
       }

       public override Paint CreatePaint()
       {
          return new BlackPaint();
       }

       public override Wheels CreateWheels()
       {
           return new Wheels18Inch();
       }
    }
}
