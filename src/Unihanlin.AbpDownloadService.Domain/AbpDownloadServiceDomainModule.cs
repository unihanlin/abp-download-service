using Volo.Abp.Caching;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpDownloadService;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(AbpCachingModule),
    typeof(AbpDownloadServiceDomainSharedModule)
)]
public class AbpDownloadServiceDomainModule : AbpModule
{

}
