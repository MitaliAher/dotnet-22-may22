import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  private _regUrl ="https://localhost:44387/api/Register";

  constructor(private http:HttpClient,_router:Router) { }

 /* getCategorys() {
    return this.http.get<any>(this._regUrl);
}
*/
}