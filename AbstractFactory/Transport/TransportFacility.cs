

using AbstractFactory.Transport.Factories.AirFactory;
using AbstractFactory.Transport.Factories.AirFactory.Interfaces;
using AbstractFactory.Transport.Factories.GroundFactory;
using AbstractFactory.Transport.Factories.GroundFactory.Interfaces;
using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport;
public class TransportFacility : ITransportFacility
{
    public  IGroundFactory CreateGroundFactory() => new GroundFactory();

    public IAirFactory CreateAirFactory() => new AirFactory();
}