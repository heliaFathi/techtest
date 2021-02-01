import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html'
})
export class ProductsComponent implements OnInit {
  products: Product[] = [];

  constructor(private service:ProductService) { }

  ngOnInit() {
    this.getAllProducts();
  }

  getAllProducts(){
    this.service.getProducts()
    .subscribe(data => this.products = data);
  }

}
