using AbstractFactory.Transport.Factories.GroundFactory.Interfaces;
using AbstractFactory.Transport.Ground;
using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport.Factories.GroundFactory;

public class GroundFactory : IGroundFactory
{
    public IGroundTransport CreateCar() => new Car();

    public IGroundTransport CreateTruck() => new Truck();
}