using Localization.Resources.AbpUi;
using Unihanlin.AbpDownloadService.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Unihanlin.AbpDownloadService;

[DependsOn(
    typeof(AbpDownloadServiceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AbpDownloadServiceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpDownloadServiceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.FormBodyBindingIgnoredTypes.Add(typeof(UploadDto));
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AbpDownloadServiceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
