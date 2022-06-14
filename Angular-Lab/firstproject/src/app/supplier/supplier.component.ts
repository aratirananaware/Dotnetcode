import { Component, OnInit } from '@angular/core';
import { Supplier } from './supplier.model';
import { HttpClient } from '@angular/common/http';
@Component({
  
  templateUrl: './supplier.component.html',
  
})
export class SupplierComponent{

  constructor(public httpc:HttpClient) {
   

  }
  //constructor() { }

 // ngOnInit(): void {
 // }
 
  title = 'firstproject';
  myname = 'Arati Rananaware'
  SupplierModel: Supplier = new Supplier();
  SupplierModels: Array<Supplier> = new Array<Supplier>();
  AddSupplier() {
    console.log(this.SupplierModel);
    //this.CustmerModels.push(this.CustomerModel);

    var supplierdto={
      supplierCode:this.SupplierModel.supplierCode,
      supplierName:this.SupplierModel.supplierName,
      supplierAmount:Number(this.SupplierModel.supplierAmount),
    }
    this.httpc.post("https://localhost:44382/api/Supplier",supplierdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
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
    var index=this.SupplierModels.indexOf(input);
    this.SupplierModels.splice(index,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44382/api/Supplier").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.SupplierModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}


