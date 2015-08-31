using System;
using Factory.Parts;
using Factory.PartsFactory;

namespace Factory.Cars
{
    public abstract class Car
    {
        protected string Name = "";
        protected string Body = "";
        protected Engine Engine;
        protected Paint PaintColor;
        protected Wheels Wheels;
        
        protected PartsCarFactory _factory;
        
        public virtual void Specification()
        {
            Console.WriteLine("Name:{0}", Name);
            Engine = _factory.CreatEngine();
            PaintColor = _factory.CreatePaint();
            Wheels = _factory.CreateWheels();
            Console.WriteLine("Body:{0}", Body);
        }
        
        public void InstallBody()
        {
            Console.WriteLine("Body is installed");
        }

        public void InstallEngine()
        {
            Console.WriteLine("Engine is installed");
        }

        public void Paint()
        {
            Console.WriteLine("Car is painted");
        }

        public void InstallWheels()
        {
            Console.WriteLine("Wheels is installed");
        }
    }
}
