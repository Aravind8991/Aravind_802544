import { Component, OnInit } from '@angular/core';
import { HttpClient } from 'selenium-webdriver/http';
import { Mentor } from 'src/app/Models/mentor-model';
import { MentorService } from 'src/app/Services/mentor.service';
import { Skills } from 'src/app/Models/skill-model';
import { SkillService } from 'src/app/Services/skill.service';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css']
})
export class CoursesComponent implements OnInit {
Skill:string;
TimeSlot:string;
item:Mentor;
item1:Skills;
list1:Skills[];
list:any;
  msg:any;

  constructor(private _service:MentorService,private myservice:SkillService) { }

  ngOnInit() {
    this.myservice.GetTechnology().subscribe(data=>this.list1=data);
  }
  public Get(){
    this._service.SearchMentor(this.Skill,this.TimeSlot).subscribe(data=>this.list=data)
    
  }
}
 


// .subscribe(k=>{
//   this.msg=k;
//   console.log(k)
