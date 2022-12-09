using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Unihanlin.AbpDownloadService.EntityFrameworkCore;

[ConnectionStringName(AbpDownloadServiceDbProperties.ConnectionStringName)]
public interface IAbpDownloadServiceDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
