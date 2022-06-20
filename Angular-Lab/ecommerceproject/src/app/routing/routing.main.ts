import { AdminComponent } from "../admin/admin.component";
import { HomeComponent } from "../home/home.component";
import { UserComponent } from "../user/user.component";

export const MainRoutes=[
    {path:'',component:HomeComponent},
    {path:'home',component:HomeComponent},
    {path:'user',loadChildren:()=>import('../user/user.module').then(m=>m.UserModule)},
    {path:'admin',loadChildren:()=>import('../admin/admin.module').then(m=>m.AdminModule)},
];



