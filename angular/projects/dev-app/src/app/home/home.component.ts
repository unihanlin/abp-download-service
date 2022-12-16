import { downloadBlob, isNullOrEmpty } from '@abp/ng.core';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AbpDownloadService } from '@unihanlin/abp-down-load-service';
import { finalize } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  name = '';
  isModalOpen = false;
  form: FormGroup;
  constructor(private fb: FormBuilder, private downloadService: AbpDownloadService) {}

  buildForm() {
    this.form = this.fb.group({
      singleFile: [null, [Validators.required]],
      files: [null, []],
      text: [null, []],
      timestamp: [null, [Validators.required]],
    });
  }

  showForm() {
    this.buildForm();
    this.isModalOpen = true;
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
      .subscribe(blob => downloadBlob(blob.blob, blob.fileName));
  }

  download() {
    if (isNullOrEmpty(this.name)) return;
    this.downloadService
      .downloadAsync(
        {
          method: 'GET',
          url: '/api/AbpDownloadService/sample/download',
          params: { name: this.name },
        },
        { apiName: 'AbpDownloadService' }
      )
      .pipe(finalize(() => (this.name = '')))
      .subscribe(blob => {
        downloadBlob(blob.blob, blob.fileName);
      });
  }
}
