import { HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable} from 'rxjs';
import { of } from 'rxjs/observable/of';
import { catchError, retry } from 'rxjs/operators';
import { _throw as throwError } from 'rxjs/observable/throw';

@Injectable()
export class GlobalHttpInterceptorService implements HttpInterceptor {
 
  constructor(public router: Router) {
  }
  
  intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
 
    return next.handle(req).pipe(
      retry(2),
      catchError((error) => {
   
        if (error instanceof HttpErrorResponse) {
          if (error.error instanceof ErrorEvent) {
            //client-side errors
             return throwError(error);
          } else {
            //server-side errors
             return (throwError(error))
          }
        }
        else {
          //other errors
          return throwError(error);
        }
      })
    )
  }
}
 