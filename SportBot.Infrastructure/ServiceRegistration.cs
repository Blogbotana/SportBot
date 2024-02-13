using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportBot.Infrastructure.Data;

namespace SportBot.Infrastructure;

public static class ServiceRegistration
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
  {
    services.AddDbContext<WorkoutContext>(options =>
    {
      var connection = configuration.GetConnectionString("DebugOrderConnection") ?? throw new ArgumentNullException("DebugOrderConnection");
      _ = options.UseNpgsql(connection);
      _ = options.EnableSensitiveDataLogging();
    });
    return services;
  }
}
