using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Unihanlin.AbpDownloadService.EntityFrameworkCore;

public class AbpDownloadServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpDownloadServiceHttpApiHostMigrationsDbContext>
{
    public AbpDownloadServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpDownloadServiceHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("AbpDownloadService"));

        return new AbpDownloadServiceHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
