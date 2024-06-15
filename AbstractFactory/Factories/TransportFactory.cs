using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.Factories;
public class TransportFactory : ITransportFactory
{
    public  IGroundFactory CreateGroundFactory() => new GroundFactory();

    public IAirFactory CreateAirFactory() => new AirFactory();
}