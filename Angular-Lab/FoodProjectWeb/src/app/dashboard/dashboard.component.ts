import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FoodService } from '../Services/food.service';
import { CartService } from '../Services/cart.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  
  public foods: any;
  constructor(private _foodservice: FoodService, private cartservice: CartService, private _router: Router) { }

  // products: Array<Product> = new Array<Product>();
  ngOnInit(): void {

    this._foodservice.getProducts().subscribe(res => {
      this.foods = res;

      this.foods.forEach((a: any) => {
        Object.assign(a, { quantity: 1 });
    });
  })
    }

  addtocart(product : any){
    this.cartservice.addtoCart(product);

  }

}
