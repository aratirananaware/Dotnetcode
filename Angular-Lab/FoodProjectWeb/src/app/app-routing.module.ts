import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccountComponent } from './account/account.component';
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import {CartComponent} from './cart/cart.component';
import { SearchComponent } from './search/search.component';
import { AddfoodComponent } from './addfood/addfood.component';
import { UpdateComponent } from './update/update.component';
import { CheckoutComponent } from './checkout/checkout.component';
const routes: Routes = [
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: '',
    component: HomeComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'register',
    component: RegisterComponent
  },
  {
    path: 'account',
    component: AccountComponent
  },
  {
    path: 'dashboard',
    component: DashboardComponent
  },
  {
    path: 'cart',
    component: CartComponent
  },
  {
    path: 'search',
    component: SearchComponent
  },
  {
    path: 'addfood',
    component: AddfoodComponent
  },
  {
    path: 'update',
    component: UpdateComponent
  },
  {
    path: 'checkout',
    component: CheckoutComponent
  },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
