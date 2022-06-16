import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Supplier } from './supplier.model';

@Component({
  templateUrl: './Supplier.component.html',
})
export class SupplierComponent {
  constructor(public httpc:HttpClient) {
   

  }
  title = 'first-sample-project';
  myname = 'vikash Verma'
  SupplierModel: Supplier = new Supplier();
  SupplierModels: Array<Supplier> = new Array<Supplier>();
  AddSupplier() {
    console.log(this.SupplierModel);
    //this.SupplierModels.push(this.SupplierModel);
    //this.SupplierModel = new Supplier();

    var supplierdto={
      SupplierCode:this.SupplierModel.SupplierCode,
      SupplierName:this.SupplierModel.SupplierName,
      SupplierAmount:Number(this.SupplierModel.SupplierAmount),
    }
    this.httpc.post("https://localhost:44373/api/Supplier",supplierdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.SupplierModel = new Supplier();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditSupplier(input: Supplier) {
    this.SupplierModel = input;
  }
  DeleteSupplier(input: Supplier) {
    var index = this.SupplierModels.indexOf(input);
    this.SupplierModels.splice(index, 1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44373/api/Supplier").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.SupplierModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}

