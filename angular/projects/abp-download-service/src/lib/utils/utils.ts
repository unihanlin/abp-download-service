import { isArray } from '@abp/ng.core';
import { FormGroup } from '@angular/forms';
import { FormField } from '../models/form-request';

export const fieldsToFormData = (fields?: FormGroup | FormField[]): FormData | null => {
  if (fields) {
    if (fields instanceof FormGroup) {
      let formData = new FormData();
      let formGroup = fields as FormGroup;
      Object.entries(formGroup.value).forEach(x => {
        const obj = x[1];
        if (obj instanceof File) {
          const file = obj as File;
          formData.append(x[0], file, file.name);
        } else if (obj instanceof Blob) {
          const blob = obj as Blob;
          formData.append(x[0], blob);
        } else if (isArray(obj)) {
          let arr = obj as any[];
          for (let i = 0; i < arr.length; i++) {
            formData.append(x[0], arr[i]);
          }
        } else if (obj) {
          formData.append(x[0], String(obj));
        }
      });

      return formData;
    } else if (isArray(fields)) {
      if (fields?.length > 0) {
        let formData = new FormData();
        fields.forEach(field => {
          if (field.content instanceof File) {
            const file = field.content as File;
            formData.append(field.fieldName || 'file', file, field.fileName || file.name);
          } else if (field.content instanceof Blob) {
            const blob = field.content as Blob;
            formData.append(field.fieldName || 'file', blob, field.fileName);
          } else if (isArray(field.content)) {
            let arr = field.content as any[];
            if (arr.length !== 0) {
              for (let i = 0; i < arr.length; i++) {
                formData.append(field.fieldName || 'files', arr[i]);
              }
            }
          } else if (typeof field.content === 'string' || <any>field.content instanceof String) {
            formData.append(field.fieldName!, String(field.content));
          }
        });
        return formData;
      }
    }
  }

  return null;
};
