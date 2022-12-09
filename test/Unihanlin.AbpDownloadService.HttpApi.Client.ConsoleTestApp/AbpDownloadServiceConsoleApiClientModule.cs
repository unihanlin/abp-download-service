using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpDownloadService;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpDownloadServiceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class AbpDownloadServiceConsoleApiClientModule : AbpModule
{

}
