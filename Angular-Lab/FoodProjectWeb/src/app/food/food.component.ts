import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FoodService } from '../Services/food.service';
import { CartService } from '../Services/cart.service';

@Component({
  selector: 'app-food',
  templateUrl: './food.component.html',
  styleUrls: ['./food.component.css']
})
export class FoodComponent implements OnInit {

  public foods : any;
  searchKey:string ="";
  constructor(private _foodservice: FoodService,private CartService : CartService,private _router:Router) { }

 // products: Array<Product> = new Array<Product>();
  ngOnInit(): void {

    this._foodservice.getProducts().subscribe(res => {this.foods = res; 

    this.foods.forEach((a :any) =>{
    Object.assign(a,{quantity:1});
  });
})
this.CartService.search.subscribe((val:any)=>{
  this.searchKey = val;
})
  }

  addtocart(product : any){
    this.CartService.addtoCart(product);

  }

}
