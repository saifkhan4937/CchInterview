import { HTTP_INTERCEPTORS } from '@angular/common/http';

import { ApiInterceptor } from './api-interceptor.service';
import { AuthInterceptor } from './auth-interceptor.service';
import { ErrorInterceptor } from './error-interceptor.service';

/** Http interceptor providers in outside-in order */
export const httpInterceptorProviders = [
  { provide: HTTP_INTERCEPTORS, useClass: ApiInterceptor, multi: true },
  { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true },
  { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
];
