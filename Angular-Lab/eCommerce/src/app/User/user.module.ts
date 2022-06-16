import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    
  ],
  imports: [
    CommonModule,
    FormsModule,
    HttpClientModule,
   // RouterModule.forChild()
  ],
  providers: [],
  //bootstrap: [t]
})
export class UserModule { }