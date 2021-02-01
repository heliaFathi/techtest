import { ErrorHandler, Injectable, Injector } from '@angular/core';
import { HttpErrorResponse } from '@angular/common/http';
import { Router } from '@angular/router';
 
@Injectable()
export class GlobalErrorHandlerService implements ErrorHandler {
 
  constructor(private injector: Injector) { 
  }
 
  handleError(error: Error | HttpErrorResponse) {
    let router = this.injector.get(Router);
        console.log('URL: ' + router.url);
        console.error(error);
       
        router.navigate(['/error']);
  }
 
}