using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport.Factories.GroundFactory.Interfaces;

public interface IGroundFactory
{
    IGroundTransport CreateCar();

    IGroundTransport CreateTruck();
}