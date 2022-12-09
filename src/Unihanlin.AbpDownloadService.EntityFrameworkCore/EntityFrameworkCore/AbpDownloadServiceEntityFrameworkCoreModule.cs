using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Unihanlin.AbpDownloadService.EntityFrameworkCore;

[DependsOn(
    typeof(AbpDownloadServiceDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class AbpDownloadServiceEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<AbpDownloadServiceDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
        });
    }
}
