namespace AbstractFactory.Factories.Interfaces;

public interface ITransportFactory
{
     IGroundFactory CreateGroundFactory();
     
     IAirFactory CreateAirFactory();
}