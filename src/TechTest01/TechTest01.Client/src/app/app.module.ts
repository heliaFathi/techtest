import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { HttpClientModule, HttpHandler, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppComponent } from './app.component';
import { ProductsComponent } from './products/products.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { ProductService } from "./services/product.service";
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { GlobalHttpInterceptorService } from './common/global-http-interceptor.service';
import { GlobalErrorHandlerService } from './common/global-error-handler.service';
import { ErrorComponent } from './error/error.component';
import { NavComponent } from './nav/nav.component';

const routes: Routes = [
   { path: '', component: HomeComponent },
   { path: 'products', component: ProductsComponent },
   { path: 'product-details/:id', component: ProductDetailsComponent },
   { path: 'error', component: ErrorComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    ProductDetailsComponent,
    HomeComponent,
    ErrorComponent,
    NavComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    [RouterModule.forRoot(routes)]
  ],
  exports: [RouterModule],
  providers: [
    ProductService,
    { provide: HTTP_INTERCEPTORS, useClass: GlobalHttpInterceptorService, multi : true},
    {provide: ErrorHandler, useClass: GlobalErrorHandlerService}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
