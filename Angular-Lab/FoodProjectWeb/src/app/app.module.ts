import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { HomeComponent } from './home/home.component';
import { AuthService } from './Services/auth.service';
import { DashboardComponent } from './dashboard/dashboard.component';
import { FoodComponent } from './food/food.component';
import { CategoryComponent } from './category/category.component';
import { CartComponent } from './cart/cart.component';
import { AddfoodComponent } from './addfood/addfood.component';
import { AddcategoryComponent } from './addcategory/addcategory.component';
import { UserinfoComponent } from './userinfo/userinfo.component';
import { FilterPipe } from './Shared/filter.pipe';
import { RestaurantComponent } from './restaurant/restaurant.component';
import { ApproveComponent } from './approve/approve.component';
import { AdddetailsComponent } from './adddetails/adddetails.component';
import { FinalorderComponent } from './finalorder/finalorder.component';
import { UpdateComponent } from './update/update.component';
//import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    DashboardComponent,
    FoodComponent,
    CategoryComponent,
    CartComponent,
    AddfoodComponent,
    AddcategoryComponent,
    UserinfoComponent,
    FilterPipe,
    RestaurantComponent,
    ApproveComponent,
    AdddetailsComponent,
    FinalorderComponent,
    UpdateComponent,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
