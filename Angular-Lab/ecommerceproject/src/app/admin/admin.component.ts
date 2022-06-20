import { Component, OnInit } from '@angular/core';
import { Admin } from './admin.model';
import { HttpClient } from '@angular/common/http';

@Component({
  templateUrl: './admin.component.html'
})
export class AdminComponent{
  constructor(public httpd:HttpClient){

  }
  title='ecommerceproject';
  AdminModel:Admin=new Admin();
  AdminModels:Array<Admin>=new Array<Admin>();
  AddAdmin(){
    console.log(this.AdminModel);
   
    var Admindto={
      AdminID:this.AdminModel.AdminID,
      AdminName:this.AdminModel.AdminName,
    }
    this.httpd.post("https://localhost:44383/api/Admin",Admindto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
   
    this.AdminModel=new Admin();
  }
  PostSuccess(res:any){
    console.log(res);

  }
  PostError(res:any){
    console.log(res);

  }
  getData(){
   // console.log("Working");
    this.httpd.get("https://localhost:44383/api/Admin").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
    console.log("working");
  }
  GetSuccess(input:any){
    this.AdminModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}




