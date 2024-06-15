using AbstractFactory.Factories.Interfaces;

namespace AbstractFactory;

public interface ITransportHandler
{
    void HandleGround(IGroundFactory groundFactory);
    void HandleAir(IAirFactory airFactory);

}