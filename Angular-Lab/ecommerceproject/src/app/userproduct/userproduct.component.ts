import { Component } from "@angular/core";
import { UserProduct } from "./userproduct.model";
import { HttpClient } from "@angular/common/http";

@Component({
  templateUrl:'./Userproduct.component.html'
})

export class UserProductComponent{
  constructor(public httpc:HttpClient){

  }
  title='ecommerceproject';
  UserProductModel: UserProduct=new UserProduct();
  UserProductModels:Array<UserProduct>=new Array<UserProduct>();
  AddUserProduct()
  {
    console.log(this.UserProductModel);

    var userproductdto={
      id:this.UserProductModel.id,
      orderID:this.UserProductModel.orderID,
    }
    this.httpc.post("",userproductdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res))
    this.UserProductModel=new UserProduct();
  }
  PostSuccess(res:any){
    console.log(res);
  }
  PostError(res:any){
    console.log(res);
  }
}