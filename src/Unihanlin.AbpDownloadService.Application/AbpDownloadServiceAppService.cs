using Unihanlin.AbpDownloadService.Localization;
using Volo.Abp.Application.Services;

namespace Unihanlin.AbpDownloadService;

public abstract class AbpDownloadServiceAppService : ApplicationService
{
    protected AbpDownloadServiceAppService()
    {
        LocalizationResource = typeof(AbpDownloadServiceResource);
        ObjectMapperContext = typeof(AbpDownloadServiceApplicationModule);
    }
}
