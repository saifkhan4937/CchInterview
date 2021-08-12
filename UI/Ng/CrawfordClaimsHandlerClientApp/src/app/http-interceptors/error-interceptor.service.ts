import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent, HttpErrorResponse } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private _router: Router) { }

  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(req)
      .pipe(
        catchError((error: HttpErrorResponse) => {
          let errorMessage = this.handleError(error);
          return throwError(errorMessage);
        })
      );
  }

  private handleError(error: HttpErrorResponse):string{
    if (error.status === 401) {
      return this.handleUnauthorized(error);
    }
    return "";
  }
  private handleUnauthorized(error: HttpErrorResponse):string{
    if (this._router.url === '/login') {
      return 'Authentication failed. Wrong Username or Password';
    }
    else {
      this._router.navigate(['/login']);
      return error.message;
    }
  }

}
