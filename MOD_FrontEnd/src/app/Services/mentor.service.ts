import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import{Mentor}from '../Models/mentor-model';



@Injectable({
  providedIn: 'root'
})
export class MentorService {
  path:string="http://localhost:5000/api/Mentor";
  path2:string="http://localhost:5000/api/User";

  constructor(private _Client:HttpClient) { }
  public Add(item:Mentor):Observable<string>{
    return this._Client.post<string>(this.path+'/AddMentor',item);
  }
  public GetMentors():Observable<Mentor[]>{
    return this._Client.get<Mentor[]>(this.path+'/GetMentors');}

    public Update(item:Mentor):Observable<any>
    {
      return this._Client.put<any>(this.path+'/UpdateMentor/',item)
    }

    public Delete(id:string)
    {
        return this._Client.delete(this.path+'/DeleteMentor/'+id)
    }
    public BlockMentor(id:string){
      return this._Client.put(this.path +'/BlockMentor/' +id,id)
    }
  

    public SearchMentor(Skill:string,TimeSlot:string){
      console.log(Skill+"  "+TimeSlot+"inside search mentor");
      return this._Client.get("http://localhost:5000/api/User/SearchMentor/"+Skill+'/'+TimeSlot);

}
  }

