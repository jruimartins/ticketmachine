using Microsoft.Extensions.DependencyInjection;
using TicketMachine.Core;

namespace TicketMachine.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            serviceProvider.GetService<App>().Run();       
        }

        private static void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStationFinder, StationFinder>();

            serviceCollection.AddScoped<IMachine, Machine>();

            serviceCollection.AddTransient<App>();
        }
    }
}
