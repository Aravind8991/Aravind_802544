import { Injectable } from '@angular/core';
import{HttpClient}from '@angular/common/http';
import{Observable}from 'Rxjs';
import { User } from '../Models/user-model';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  path1:string="http://localhost:5000/api/User";
 

  constructor(private _Client:HttpClient) { }
  public AddUser(item:User):Observable<string>{
    return this._Client.post<string>(this.path1+'/AddUser',item);}

    public GetUsers():Observable<User[]>{
      return this._Client.get<User[]>(this.path1+'/GetUsers');}

      public Update(item:User):Observable<any>
      {
        return this._Client.put<any>(this.path1+'/UpdateUser/',item)
      }
  
      public Delete(id:string)
      {
          return this._Client.delete(this.path1+'/DeleteUser/'+id)
      }
      public BlockUser(id:string){
        return this._Client.put(this.path1 +'/BlockUser/' +id,id)
      }
    
}
