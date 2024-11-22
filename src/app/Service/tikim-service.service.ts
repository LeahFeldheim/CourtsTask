import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TikModel } from '../model/tik.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TikimServiceService {
private apiUrl = 'http://localhost:5000/api/Cases';
  constructor( private http:HttpClient) {

   }
   getTikimFromDB() :Observable<any>{
   return this.http.get(`${this.apiUrl}/GetAllTik`);
   }
}
