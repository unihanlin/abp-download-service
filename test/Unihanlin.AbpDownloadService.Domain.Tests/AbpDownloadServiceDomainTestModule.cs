using Unihanlin.AbpDownloadService.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpDownloadService;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(AbpDownloadServiceEntityFrameworkCoreTestModule)
    )]
public class AbpDownloadServiceDomainTestModule : AbpModule
{

}
