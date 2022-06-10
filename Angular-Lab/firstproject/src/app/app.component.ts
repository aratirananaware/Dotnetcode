import { Component } from '@angular/core';
import { Customer } from './app.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'firstproject';
  CustomerModel:Customer=new Customer();

  CustmerModels: Array<Customer> = new Array<Customer>();
  
  AddCustomer() {
    this.CustmerModels.push(this.CustomerModel);
    this.CustomerModel = new Customer();
  }
  EditCustomer(input: Customer) {
    this.CustomerModel=input;
  }
  DeleteCustomer(input: Customer) {
    var index=this.CustmerModels.indexOf(input);
    this.CustmerModels.splice(index,1);
}
}
