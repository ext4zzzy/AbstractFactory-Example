using AbstractFactory.Transport.Interfaces;

namespace AbstractFactory.Transport.Factories.AirFactory.Interfaces;

public interface IAirFactory
{
    IAirTransport CreateAircraft();

    IAirTransport CreateHelicopter();
}
