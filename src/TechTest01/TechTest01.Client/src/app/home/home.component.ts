import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  products: Product[] = [];

  constructor(private service:ProductService) { }

  ngOnInit() {
    this.getRandomProducts();
  }

  getRandomProducts(){
    this.service.getRandomProducts()
     .subscribe(data => this.products = data);
  }

}
