import { Component, OnInit } from '@angular/core';
import { Training } from 'src/app/Models/Training-model';
import { TrainingService } from 'src/app/Services/training.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-userdashboard',
  templateUrl: './userdashboard.component.html',
  styleUrls: ['./userdashboard.component.css']
})
export class UserdashboardComponent implements OnInit {
  item:Training;
  list:Training[];
  msg:string;

  constructor(private service:TrainingService ,private router:Router) { }

  ngOnInit() {
  }

  GetOTs(){
    this.service.GetCompletedTrainings().subscribe(k=>this.list=k)
  }
  GetCTs(){
    this.service.GetOnGoingTrainings().subscribe(data=>this.list=data)
  }
}
