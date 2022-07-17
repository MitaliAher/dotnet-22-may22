import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Food } from '../Models/food';
import { FoodService } from '../Services/food.service';

@Component({
  selector: 'app-addfood',
  templateUrl: './addfood.component.html',
  styleUrls: ['./addfood.component.css']
})
export class AddfoodComponent implements OnInit {

  constructor(public httpc:HttpClient,private _foodservice:FoodService,private _router:Router) { }

  ngOnInit(): void {
  }

  addfood: Food = new Food();
  addfoods:Array<Food>=new Array<Food>();

  AddFood(){
    console.log(this.addfood)

    var addo={
      catId:Number(this.addfood.catId),
      foodName:this.addfood.foodName,
      foodDescription:this.addfood.foodDescription,
      foodPrice:this.addfood.foodPrice,
      foodImage:this.addfood.foodImage
    }

    this.httpc.post("https://localhost:44385/api/Food",addo).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.addfood=new Food();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }

  Show(){
    console.log("Hi");
    this.httpc.get("https://localhost:44385/api/Food").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.addfoods=input;
  }
  GetError(input:any){
    console.log(input);
  }
  }

