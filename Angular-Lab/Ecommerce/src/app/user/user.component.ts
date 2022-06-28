import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'first-sample-project';
  myname = 'vikash Verma'
  CustomerModel: Customer = new Customer();
  CustmerModels: Array<Customer> = new Array<Customer>();
  AddCustomer() {
    console.log(this.CustomerModel);
    //this.CustmerModels.push(this.CustomerModel);

    var customerdto={
      customerCode:this.CustomerModel.customerCode,
      customerName:this.CustomerModel.customerName,
      customerAmount:Number(this.CustomerModel.customerAmount),
    }
    this.httpc.post("https://localhost:44381/api/Customer",customerdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.CustomerModel = new Customer();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditCustomer(input: Customer) {
    this.CustomerModel = input;
  }
  DeleteCustomer(input: Customer) {
    var index=this.CustmerModels.indexOf(input);
    this.CustmerModels.splice(index,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44381/api/Customer").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.CustmerModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}