using AbstractFactory.Transport.Factories.AirFactory.Interfaces;
using AbstractFactory.Transport.Factories.GroundFactory.Interfaces;

namespace AbstractFactory.Transport.Interfaces;

public interface ITransportFacility
{
     IGroundFactory CreateGroundFactory();
     
     IAirFactory CreateAirFactory();
}