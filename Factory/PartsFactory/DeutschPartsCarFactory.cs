using Factory.Parts;

namespace Factory.PartsFactory
{
    public class DeutschPartsCarFactory : PartsCarFactory
    {
        public override Engine CreatEngine()
        {
            return new Gasoline();
        }

        public override Paint CreatePaint()
        {
           return new GreyPaint();
        }

        public override Wheels CreateWheels()
        {
            return new Wheels18inch();
        }
    }
}
