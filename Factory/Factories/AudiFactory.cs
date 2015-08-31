using Factory.Cars;

namespace Factory.Factories
{
    abstract class AudiFactory
    {
        public Car GetCar(string type)
        {
            Car car = CreateCar(type);

            car.InstallBody();
            car.InstallEngine();
            car.InstallWheels();
            car.Paint();
            car.Specification();

            return car;
        }

        public abstract Car CreateCar(string type);
    }
}
