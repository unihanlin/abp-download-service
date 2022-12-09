using Unihanlin.AbpDownloadService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Unihanlin.AbpDownloadService;

public abstract class AbpDownloadServiceController : AbpControllerBase
{
    protected AbpDownloadServiceController()
    {
        LocalizationResource = typeof(AbpDownloadServiceResource);
    }
}
