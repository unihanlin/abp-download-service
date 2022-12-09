using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Unihanlin.AbpDownloadService.Seed;

public class AbpDownloadServiceHttpApiHostDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly AbpDownloadServiceSampleDataSeeder _abpDownloadServiceSampleDataSeeder;
    private readonly ICurrentTenant _currentTenant;

    public AbpDownloadServiceHttpApiHostDataSeedContributor(
        AbpDownloadServiceSampleDataSeeder abpDownloadServiceSampleDataSeeder,
        ICurrentTenant currentTenant)
    {
        _abpDownloadServiceSampleDataSeeder = abpDownloadServiceSampleDataSeeder;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            await _abpDownloadServiceSampleDataSeeder.SeedAsync(context);
        }
    }
}
