import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Training } from '../Models/training-model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TrainingService {
  path:string="http://localhost:5001/api/Training";

  constructor(private client:HttpClient) { }
  public GetTrainings():Observable<Training[]>
  {
    return this.client.get<Training[]>(this.path+'/GetTrainings')
  }
  public GetCompletedTrainings():Observable<Training[]>
  {
    return this.client.get<Training[]>(this.path+'/GetCompletedTrainings')
  }
  public GetOnGoingTrainings():Observable<Training[]>
  {
    return this.client.get<Training[]>(this.path+'/GetOnGoingTrainings')
  }
}
