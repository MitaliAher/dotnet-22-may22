import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CartService } from '../Services/cart.service';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  /*constructor() { }

  ngOnInit(): void {
  }*/

  public foods : any = [];
  public grandTotal !: number;
  constructor(private _cart: CartService,private _router:Router) { }

  ngOnInit(): void {
    this._cart.getProductts()
    .subscribe(res=>{
      this.foods = res;
      this.grandTotal = this._cart.getTotalPrice();
    })
  }

  removeItem(item: any){
    this._cart.removeCartItem(item);
  }
  emptycart(){
    this._cart.removeAllCart();
  }
}


