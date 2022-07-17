import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AddfoodComponent } from '../addfood/addfood.component';
import { Food } from '../Models/food';
import { FoodService } from '../Services/food.service';

@Component({
  selector: 'app-approve',
  templateUrl: './approve.component.html',
  styleUrls: ['./approve.component.css']
})
export class ApproveComponent implements OnInit {

  constructor(public httpc:HttpClient,private _foodservice:FoodService,private _router:Router,private _addfood:AddfoodComponent) { }

  ngOnInit(): void {
  }
  addfood: Food = new Food();
  addfoods:Array<Food>=new Array<Food>();

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
