import type { SampleDto } from './models';
import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { UploadDto } from '../models';

@Injectable({
  providedIn: 'root',
})
export class SampleService {
  apiName = 'AbpDownloadService';
  

  download = (name: string) =>
    this.restService.request<any, Blob>({
      method: 'GET',
      responseType: 'blob',
      url: '/api/AbpDownloadService/sample/download',
      params: { name },
    },
    { apiName: this.apiName });
  

  get = () =>
    this.restService.request<any, SampleDto>({
      method: 'GET',
      url: '/api/AbpDownloadService/sample',
    },
    { apiName: this.apiName });
  

  getAuthorized = () =>
    this.restService.request<any, SampleDto>({
      method: 'GET',
      url: '/api/AbpDownloadService/sample/authorized',
    },
    { apiName: this.apiName });
  

  transfer = (input: UploadDto) =>
    this.restService.request<any, Blob>({
      method: 'POST',
      responseType: 'blob',
      url: '/api/AbpDownloadService/sample/transfer',
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
