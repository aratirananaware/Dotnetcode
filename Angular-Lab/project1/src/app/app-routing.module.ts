import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CartComponent } from './cart/cart.component';
import { ContactusComponent } from './contactus/contactus.component';
import { ProductsComponent } from './products/products.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
{path:'', redirectTo:'products',pathMatch:'full'},
  
  {path:'cart', component: CartComponent},
  {path:'contactus', component: ContactusComponent},
  {path:'products', component: ProductsComponent},
  {path: 'Home',component:HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }