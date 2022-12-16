# AbpDownloadService

An download service base on ABP for angular.

## Install

```
npm install @unihanlin/abp-down-load-service
```

## Usage

```typescript
import { AbpDownloadService } from '@unihanlin/abp-down-load-service';
import { downloadBlob } from '@abp/ng.core';

constructor(
    private downloadService: AbpDownloadService
){
}

submitForm() {
    this.downloadService
      .downloadAsync(
        {
          method: 'POST',
          url: '/api/AbpDownloadService/sample/transfer',
          fields: this.form,
        },
        { apiName: 'AbpDownloadService' }
      )
      .subscribe(blobInfo => downloadBlob(blobInfo.blob, blobInfo.fileName));
  }
```
