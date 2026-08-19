using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Festpay.Onboarding.Infra.Context;

public class FestpayContextFactory : IDesignTimeDbContextFactory<FestpayContext>
{
    public FestpayContext CreateDbContext()
    {
        string[] args = [""];
        return CreateDbContext(args);
    }

    public FestpayContext CreateDbContext(string[] args)
    {
        var connectionString = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING") ?? "Data Source=C:\\teste-fastpay\\festpay-onboarding-api\\Festpay.Onboarding.Infra\\festpay.db;";

        // SQLite
        var optionsBuilder = new DbContextOptionsBuilder<FestpayContext>();
        optionsBuilder
            .UseSqlite(connectionString)
            .EnableSensitiveDataLogging(false)
            .EnableDetailedErrors(false);

        return new FestpayContext(optionsBuilder.Options);
    }
}
