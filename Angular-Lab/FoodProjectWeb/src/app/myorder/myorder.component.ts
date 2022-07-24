import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { UserData } from '../models/UserData';
import { order } from '../models/order';
import { AuthService } from '../services/auth.service';
import { ProductService } from '../services/product.service';
import { JwtHelperService } from '@auth0/angular-jwt';

@Component({
  selector: 'app-myorder',
  templateUrl: './myorder.component.html'
})
export class MyorderComponent implements OnInit {

  constructor(private jwt:JwtHelperService,private _auth:AuthService,private http:HttpClient,private _productService:ProductService) { }
  myordersModels:any;
  username:string='';
  users:Array<UserData>=new Array<UserData>();
  
  ngOnInit(): void {
    this.username=this.jwt.decodeToken(this._auth.getToken()?.toString())?.unique_name;

    this._productService.getMyOrders(this.username).subscribe(res=>{this.myordersModels=res;});
  }

}