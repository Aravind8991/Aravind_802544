import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
 

  path:string="http://localhost:5005/api/Login";
  constructor(private _Client:HttpClient) { }
public Login(id,password):Observable<any>{
  return this._Client.get<any>(this.path+'/validate/'+id+'/'+password);
}
 
}
