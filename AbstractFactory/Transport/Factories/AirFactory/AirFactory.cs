

using AbstractFactory.Transport.Air;
using AbstractFactory.Transport.Factories.AirFactory.Interfaces;
using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport.Factories.AirFactory;

public class AirFactory : IAirFactory
{
    public IAirTransport CreateAircraft() => new Aircraft();
    
    public IAirTransport CreateHelicopter() => new Helicopter();
}