import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class FoodService {
  private _foodUrl = "https://localhost:44374/api/Food";
  constructor(private http: HttpClient,private _router:Router) { }

  
  getProducts() {
    return this.http.get<any>(this._foodUrl);
  }
}