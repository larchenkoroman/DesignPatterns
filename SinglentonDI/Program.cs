using Microsoft.Extensions.DependencyInjection;
using System.Threading.Channels;

IServiceCollection services =  new ServiceCollection();

services.AddSingleton<Logger>();
var serviceProvider = services.BuildServiceProvider();

var logger1 = serviceProvider.GetRequiredService<Logger>();
var logger2 = serviceProvider.GetRequiredService<Logger>();
var logger3 = serviceProvider.GetRequiredService<Logger>();
var logger4 = serviceProvider.GetRequiredService<Logger>();

Console.WriteLine(logger1.Equals(logger2).ToString());

class Logger
{
    public Logger()
    {
        Console.WriteLine("Loger instanciating");
    }
}