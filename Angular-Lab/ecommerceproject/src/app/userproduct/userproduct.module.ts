import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { RouterModule } from "@angular/router";
import { UserProductComponent } from "./userproduct.component";
import { UserProductRoutes } from "../routing/routing.userproduct";
import { HttpClientModule } from "@angular/common/http";

@NgModule({
    declarations:[
        UserProductComponent,
    ],
    imports:[
        CommonModule,
        FormsModule,
        HttpClientModule,
        RouterModule.forChild(UserProductRoutes)
    ],

    providers:[],
    bootstrap:[UserProductComponent]
})

export class UserProductModule{}

