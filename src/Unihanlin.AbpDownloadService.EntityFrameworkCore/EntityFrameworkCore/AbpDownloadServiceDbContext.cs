using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Unihanlin.AbpDownloadService.EntityFrameworkCore;

[ConnectionStringName(AbpDownloadServiceDbProperties.ConnectionStringName)]
public class AbpDownloadServiceDbContext : AbpDbContext<AbpDownloadServiceDbContext>, IAbpDownloadServiceDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AbpDownloadServiceDbContext(DbContextOptions<AbpDownloadServiceDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAbpDownloadService();
    }
}
