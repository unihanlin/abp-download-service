import { Injectable } from '@angular/core';
import { RestService, Rest } from '@abp/ng.core';
import { HttpRequest, HttpResponse } from '@angular/common/http';
import { FormRequest } from '../models/form-request';
import { map } from 'rxjs/operators';
import { BlobInfo } from '../models';
import { fieldsToFormData } from '../utils/utils';

@Injectable({
  providedIn: 'root',
})
export class AbpDownloadService {
  constructor(private restService: RestService) {}

  downloadAsync = (
    request: HttpRequest<any> | FormRequest<any>,
    config?: Rest.Config,
    api?: string
  ) => {
    request = {
      ...request,
      responseType: 'blob',
    };
    const formData = fieldsToFormData((<FormRequest<any>>request)?.fields);
    if (formData) {
      request = {
        ...request,
        body: formData,
      };
    }

    return this.restService
      .request<any, HttpResponse<Blob>>(request, { observe: Rest.Observe.Response, ...config }, api)
      .pipe(
        map(response => {
          const contentDisposition = response.headers
            ? response.headers.get('content-disposition')
            : undefined;

          if (!contentDisposition) return { blob: response.body, fileName: null } as BlobInfo;

          const fileNameEncodedMatch = /filename\*=UTF-8''?([^"]*?)"?(;|$)/g.exec(
            contentDisposition
          );

          let fileNameEncoded =
            fileNameEncodedMatch.length > 1 ? fileNameEncodedMatch[1] : undefined;
          if (fileNameEncoded) {
            let fileNameDecoded = this.urlDecode(fileNameEncoded);
            return { blob: response.body, fileName: fileNameDecoded } as BlobInfo;
          }

          const filenameMatch = /filename="?([^"]*?)"?(;|$)/g.exec(contentDisposition);
          let fileName = filenameMatch.length > 1 ? filenameMatch[1] : undefined;
          return { blob: response.body, fileName: fileName } as BlobInfo;
        })
      );
  };

  private urlDecode(text: string) {
    return decodeURIComponent(text.replace(/\+/g, ' '));
  }
}
