using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Unihanlin.AbpDownloadService.EntityFrameworkCore;

public class AbpDownloadServiceHttpApiHostMigrationsDbContext : AbpDbContext<AbpDownloadServiceHttpApiHostMigrationsDbContext>
{
    public AbpDownloadServiceHttpApiHostMigrationsDbContext(DbContextOptions<AbpDownloadServiceHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureAbpDownloadService();
        modelBuilder.ConfigureAuditLogging();
        modelBuilder.ConfigurePermissionManagement();
        modelBuilder.ConfigureSettingManagement();
    }
}
