import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CartService {

  public cartItemList: any = []
  public foods = new BehaviorSubject<any>([]);
  //public search = new BehaviorSubject<string>("");

  constructor() { }
  getProductts() {
    return this.foods.asObservable();
  }

  setProduct(productt: any) {
    this.cartItemList.push(...productt);
    this.foods.next(productt);
  }
  addtoCart(productt: any) {
    this.cartItemList.push(productt);
    this.foods.next(this.cartItemList);
    this.getTotalPrice();
    console.log(this.cartItemList)
  }

  getTotalPrice():number {
    let grandTotal = 0;
    this.cartItemList.map((a:any)=>{
     // grandTotal +=a.foodPrice;
     grandTotal = grandTotal + a.foodPrice;
    })
    return grandTotal;
  }
  removeCartItem(productt: any) {
    this.cartItemList.map((a: any, index: any) => {
      if (productt.id === a.id) {
        this.cartItemList.splice(index, 1);
      }
    })
    this.foods.next(this.cartItemList);
  }
  removeAllCart() {
    this.cartItemList = []
    this.foods.next(this.cartItemList);
  }
}