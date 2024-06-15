using AbstractFactory;
using AbstractFactory.Factories;
using AbstractFactory.Factories.Interfaces;
using AbstractFactory.TransportHandler;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices((_, services) =>
    {
        services.AddSingleton<ITransportHandler, TransportHandler>();
        services.AddSingleton<ITransportFactory, TransportFactory>();
    })
    .Build();

ITransportFactory transportFactory = host.Services.GetRequiredService<ITransportFactory>();
ITransportHandler transportHandler = host.Services.GetRequiredService<ITransportHandler>();
    
ClientHandler clientHandler = new();
clientHandler.Handle( transportHandler, transportFactory);