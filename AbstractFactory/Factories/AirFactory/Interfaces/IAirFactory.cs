namespace AbstractFactory.Factories.Interfaces;

public interface IAirFactory
{
    ITransport CreateAircraft();

    ITransport CreateHelicopter();
}
