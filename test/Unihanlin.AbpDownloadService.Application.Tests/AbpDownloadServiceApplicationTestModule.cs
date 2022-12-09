using Volo.Abp.Modularity;

namespace Unihanlin.AbpDownloadService;

[DependsOn(
    typeof(AbpDownloadServiceApplicationModule),
    typeof(AbpDownloadServiceDomainTestModule)
    )]
public class AbpDownloadServiceApplicationTestModule : AbpModule
{

}
