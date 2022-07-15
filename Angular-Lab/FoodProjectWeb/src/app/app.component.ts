import { Component } from '@angular/core';
import { AuthService } from './Services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'FoodProjectWeb';

  public foods:any;
  searchKey:string='';

  public searchTerm:string='';
  CartService: any;
  FoodService: any;

  constructor(private _auth:AuthService){

  }
  LoggedIn(input:boolean){
    if(input){
      return this._auth.loggedIn();
    }
    else{
      return !this._auth.loggedIn();
    }
  }
  LogOut(){
    this._auth.logoutUser();
  }

  search(event:any)
  {
    this.searchTerm=(event.target as HTMLInputElement).value;
    console.log(this.searchTerm);
    this.FoodService.search.next(this.searchTerm);
  }
}