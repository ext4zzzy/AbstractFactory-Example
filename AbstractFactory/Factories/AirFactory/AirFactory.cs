using AbstractFactory.AirTransport;
using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory.Factories;

public class AirFactory : IAirFactory
{
    public ITransport CreateAircraft() => new Aircraft();
    
    public ITransport CreateHelicopter() => new Helicopter();
}