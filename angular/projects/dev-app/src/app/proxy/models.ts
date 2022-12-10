import type { IRemoteStreamContent } from './volo/abp/content/models';

export interface UploadDto {
  text?: string;
  timestamp: number;
  file1: IRemoteStreamContent;
  file2: IRemoteStreamContent;
}
