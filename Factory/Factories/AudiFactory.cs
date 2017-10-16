using Factory.Cars;

namespace Factory.Factories
{
    public abstract class AudiFactory
    {
        public abstract Car CreateCar(string type);

        public Car GetCar(string type)
        {
            var car = CreateCar(type);

            car.InstallBody();
            car.InstallEngine();
            car.InstallWheels();
            car.Paint();
            car.Specification();

            return car;
        }
    }
}
