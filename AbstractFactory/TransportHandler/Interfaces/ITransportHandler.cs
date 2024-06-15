
using AbstractFactory.Transport.Factories.AirFactory.Interfaces;
using AbstractFactory.Transport.Factories.GroundFactory.Interfaces;

namespace AbstractFactory.TransportHandler.Interfaces;

public interface ITransportHandler
{
    void HandleGround(IGroundFactory groundFactory);
    void HandleAir(IAirFactory airFactory);

}