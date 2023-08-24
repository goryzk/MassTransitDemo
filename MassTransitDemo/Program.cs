using MassTransit;
using MassTransitDemo;

var builder = WebApplication.CreateBuilder();

builder.Services.AddMassTransit(x =>
{
    var assembly = typeof(IAssemblyMarker).Assembly;
    x.AddConsumers(assembly);
    
    x.UsingAmazonSqs((context, cfg) =>
    {
        cfg.Host("ap-northeast-1", _ => {});
        cfg.ConfigureEndpoints(context);
    });
    
    //x.UsingRabbitMq((context, cfg) =>
    //{
    //    cfg.Host("localhost");
    //    cfg.ConfigureEndpoints(context);
    //});
});

builder.Services.AddLogging();

var app = builder.Build();

app.Run();