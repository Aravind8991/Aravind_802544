import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Skills } from '../Models/skill-model';


@Injectable({
  providedIn: 'root'
})
export class SkillService {
  path:string='http://localhost:5002/api/Skill';
  constructor(private client:HttpClient) { }
  public GetTechnology():Observable<Skills[]>
  {
    return this.client.get<Skills[]>(this.path+'/GetTechnology')
  }
  public Add(item:Skills):Observable<any>
  {
    return this.client.post<any>(this.path+'/AddTechnology',item)
  }
  public Update(item:Skills):Observable<any>
  {
    return this.client.put<any>(this.path+'/UpdateTechnology',item)
  }
  public Search(id:string):Observable<any>
  {
    return this.client.get<any>(this.path+'/GetSkillById/'+id)
  }
  

  public Delete(id:string)
    {
        return this.client.delete(this.path+'/DeleteTechnology/'+id)
    }

}
