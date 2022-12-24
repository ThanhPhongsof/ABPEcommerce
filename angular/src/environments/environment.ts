import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'ABPEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44342/',
    redirectUri: baseUrl,
    clientId: 'ABPEcommerce_App',
    responseType: 'code',
    scope: 'offline_access ABPEcommerce',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44365',
      rootNamespace: 'ABPEcommerce',
    },
  },
} as Environment;
