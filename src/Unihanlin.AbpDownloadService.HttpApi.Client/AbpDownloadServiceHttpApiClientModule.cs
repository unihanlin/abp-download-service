using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Unihanlin.AbpDownloadService;

[DependsOn(
    typeof(AbpDownloadServiceApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class AbpDownloadServiceHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AbpDownloadServiceApplicationContractsModule).Assembly,
            AbpDownloadServiceRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpDownloadServiceHttpApiClientModule>();
        });
    }
}
