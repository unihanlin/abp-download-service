import { Rest } from '@abp/ng.core';
import { FormGroup } from '@angular/forms';

export interface FormField {
  fieldName?: string;
  content: File | Blob | string | File[] | Blob[];
  fileName?: string;
}

export interface FormRequest<T> extends Rest.Request<T> {
  fields?: FormField[] | FormGroup;
}
