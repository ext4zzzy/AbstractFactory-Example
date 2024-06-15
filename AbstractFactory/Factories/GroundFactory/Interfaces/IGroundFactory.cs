namespace AbstractFactory.Factories.Interfaces;

public interface IGroundFactory
{
    ITransport CreateCar();

    ITransport CreateTruck();
}