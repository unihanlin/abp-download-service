using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpDownloadService;

[DependsOn(
    typeof(AbpDownloadServiceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationAbstractionsModule)
    )]
public class AbpDownloadServiceApplicationContractsModule : AbpModule
{

}
