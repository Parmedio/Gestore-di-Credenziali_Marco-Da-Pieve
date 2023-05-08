using Credential_Manager.PasswordChecker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Credential_Manager
{
    public static class Startup
    {
        public static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, service) =>
                {
                    service.AddSingleton<PWChecksHandler>();
                    service.AddSingleton<PWChecksHandler>();


                    //service.AddSingleton<IIncrement>(_ => new Increment(5));
                    //service.AddScoped<Circle>();
                    //service.AddTransient<ICircle>(_ => new CircleBis(pigreco));


                });
        }
    }
}
