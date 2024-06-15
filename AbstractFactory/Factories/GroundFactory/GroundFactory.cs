using AbstractFactory.Factories.GroundTransport;
using AbstractFactory.Factories.Interfaces;
using AbstractFactory.GroundTransport;

namespace AbstractFactory.Factories;

public class GroundFactory : IGroundFactory
{
    public ITransport CreateCar() => new Car();

    public ITransport CreateTruck() => new Truck();
}