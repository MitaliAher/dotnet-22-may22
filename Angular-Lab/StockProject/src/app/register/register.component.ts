import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Register } from '../models/register';
import { RegisterService } from '../Services/register.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent  {

  constructor(public httpc: HttpClient, private _regservice:RegisterService, private _router: Router) { }

  ngOnInit(): void {
  }

  regi:Register = new Register();
  regis:Array<Register>=new Array<Register>();

  RegisterNow()
  {
    console.log(this.regi)

    var registerO={
    companyCode:Number(this.regi.companyCode),
    companyName:this.regi.companyName,
    companyCeo:this.regi.companyCeo,
    companyTurnover:Number(this.regi.companyTurnover),
    companyWebsite:this.regi.companyWebsite,
    stockExchange:this.regi.stockExchange,

    }
    this.httpc.post("https://localhost:44387/api/Register",registerO).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.regi=new Register();
  }
  PostSuccess(res:any){
    console.log(res);
  }
  PostError(res:any){
    console.log(res);
  }
  }


