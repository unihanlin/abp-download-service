using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Unihanlin.AbpDownloadService.Samples;

[Area(AbpDownloadServiceRemoteServiceConsts.ModuleName)]
[RemoteService(Name = AbpDownloadServiceRemoteServiceConsts.RemoteServiceName)]
[Route("api/AbpDownloadService/sample")]
public class SampleController : AbpDownloadServiceController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
