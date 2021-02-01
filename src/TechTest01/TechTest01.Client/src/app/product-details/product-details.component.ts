import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../models/product';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html'
})
export class ProductDetailsComponent implements OnInit {
 product: Product;
  constructor(private service: ProductService, private route: ActivatedRoute) { }

  ngOnInit() {
    let id = this.route.snapshot.paramMap.get('id');

    this.getProductDetails(id);
  }

  getProductDetails(id: any){
    this.service.getProductById(id)
        .subscribe(data => this.product = data)
  }
}
