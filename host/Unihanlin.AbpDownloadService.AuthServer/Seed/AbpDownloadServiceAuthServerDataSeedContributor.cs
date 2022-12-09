using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace Unihanlin.AbpDownloadService.Seed;

public class AbpDownloadServiceAuthServerDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly AbpDownloadServiceSampleIdentityDataSeeder _abpDownloadServiceSampleIdentityDataSeeder;
    private readonly AbpDownloadServiceAuthServerDataSeeder _abpDownloadServiceAuthServerDataSeeder;
    private readonly ICurrentTenant _currentTenant;

    public AbpDownloadServiceAuthServerDataSeedContributor(
        AbpDownloadServiceAuthServerDataSeeder abpDownloadServiceAuthServerDataSeeder,
        AbpDownloadServiceSampleIdentityDataSeeder abpDownloadServiceSampleIdentityDataSeeder,
        ICurrentTenant currentTenant)
    {
        _abpDownloadServiceAuthServerDataSeeder = abpDownloadServiceAuthServerDataSeeder;
        _abpDownloadServiceSampleIdentityDataSeeder = abpDownloadServiceSampleIdentityDataSeeder;
        _currentTenant = currentTenant;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            await _abpDownloadServiceSampleIdentityDataSeeder.SeedAsync(context);
            await _abpDownloadServiceAuthServerDataSeeder.SeedAsync(context);
        }
    }
}
