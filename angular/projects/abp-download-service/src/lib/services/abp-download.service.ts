import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class AbpDownloadService {
  apiName = 'AbpDownloadService';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/AbpDownloadService/sample' },
      { apiName: this.apiName }
    );
  }
}
