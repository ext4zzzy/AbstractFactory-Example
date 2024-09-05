using AbstractFactory;
using AbstractFactory.Transport;
using AbstractFactory.Transport.Interfaces;
using AbstractFactory.TransportHandler;
using AbstractFactory.TransportHandler.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices((_, services) =>
    {
        services.AddSingleton<ITransportHandler, TransportHandler>();
        services.AddSingleton<ITransportFacility, TransportFacility>();
    })
    .Build();

ITransportFacility transportFacility = host.Services.GetRequiredService<ITransportFacility>();
ITransportHandler transportHandler = host.Services.GetRequiredService<ITransportHandler>();
    
ClientHandler clientHandler = new();
clientHandler.Handle( transportHandler, transportFacility);