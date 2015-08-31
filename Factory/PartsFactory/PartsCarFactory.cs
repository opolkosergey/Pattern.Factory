using Factory.Parts;

namespace Factory.PartsFactory
{
    public abstract class PartsCarFactory
    {
        public abstract Engine CreatEngine();
        public abstract Paint CreatePaint();
        public abstract Wheels CreateWheels();

    }
}
