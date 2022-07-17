import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Details } from '../Models/detail';
import { AdddetailService } from '../Services/adddetail.service';
import { FoodService } from '../Services/food.service';

@Component({
  selector: 'app-adddetails',
  templateUrl: './adddetails.component.html',
  styleUrls: ['./adddetails.component.css']
})
export class AdddetailsComponent implements OnInit {


  constructor(public httpc: HttpClient, private _detail: AdddetailService, private _router: Router) { }

  ngOnInit(): void {
  }

  adddetail: Details = new Details();
  adddetails: Array<Details> = new Array<Details>();

  Adddetail() {
    console.log(this.adddetail)

    var deto = {

      orderId: Number(this.adddetail.orderId),
      userId: this.adddetail.userId,
      userName: this.adddetail.userName,
      paymentMode: this.adddetail.paymentMode,
      address: this.adddetail.address
    }
    this.httpc.post("https://localhost:44385/api/Order", deto).subscribe(res => this.PostSuccess(res), res => this.PostError(res));
    this.adddetail = new Details();


  }

  PostSuccess(res: any) {
    console.log(res);

  }
  PostError(res: any) {
    console.log(res);
  }

  Show() {
    console.log("Hi");
    this.httpc.get("https://localhost:44385/api/Order").subscribe(res => this.GetSuccess(res), res => this.GetError(res));
  }
  GetSuccess(input: any) {
    this.adddetails = input;
  }
  GetError(input: any) {
    console.log(input);
  }


}

  
