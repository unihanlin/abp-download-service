import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44341/',
  redirectUri: baseUrl,
  clientId: 'AbpDownloadService_App',
  responseType: 'code',
  scope: 'offline_access AbpDownloadService',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'AbpDownloadService',
    logoUrl: '',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44341',
      rootNamespace: 'one-dispatch.AbpDownloadService',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
    AbpDownloadService: {
      url: 'https://localhost:44325',
      rootNamespace: 'one-dispatch.AbpDownloadService',
    },
  },
} as Environment;
