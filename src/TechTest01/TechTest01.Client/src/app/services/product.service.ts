import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Product } from '../models/product';
import { map } from 'rxjs/operators';

@Injectable()
export class ProductService {

  private apiUrl: string = 'https://localhost:44319/';
  products: Product[] = [];

  constructor(private http: HttpClient) { }

  getRandomProducts() {
    return this.http.get<Product[]>(this.apiUrl,
      { observe: 'response', params: new HttpParams().set('count', "2")})
      .pipe(map(resp => resp.body))
  }
}
