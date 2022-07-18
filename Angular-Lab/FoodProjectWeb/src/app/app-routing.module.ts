import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddcategoryComponent } from './addcategory/addcategory.component';
import { AdddetailsComponent } from './adddetails/adddetails.component';
import { AddfoodComponent } from './addfood/addfood.component';
import { ApproveComponent } from './approve/approve.component';
import { CartComponent } from './cart/cart.component';
import { CategoryComponent } from './category/category.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FinalorderComponent } from './finalorder/finalorder.component';
import { FoodComponent } from './food/food.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { RestaurantComponent } from './restaurant/restaurant.component';
import { UpdateComponent } from './update/update.component';
import { UserinfoComponent } from './userinfo/userinfo.component';

const routes: Routes = [
  {
    path: 'home',
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
    path: 'dashboard',
    component: DashboardComponent
  },
  {
    path: 'food',
    component: FoodComponent
  },
  {
    path: 'cart',
    component: CartComponent
  },
  {
    path: 'addfood',
    component: AddfoodComponent
  },
  {
    path: 'addcategory',
    component: AddcategoryComponent
  },
  {
    path: 'userinfo',
    component: UserinfoComponent
  },
  {
    path: 'restaurant',
    component: RestaurantComponent
  },
  {
    path: 'approve',
    component: ApproveComponent
  },
  {
    path: 'adddetails',
    component: AdddetailsComponent
  },
  {
    path: 'final',
    component: FinalorderComponent
  },
  {
    path: 'category',
    component: CategoryComponent
  },
  {
    path: 'update',
    component: UpdateComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
