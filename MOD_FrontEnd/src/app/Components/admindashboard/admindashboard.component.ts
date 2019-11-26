import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/Services/user.service';
import { MentorService } from 'src/app/Services/mentor.service';
import { FormBuilder } from '@angular/forms';
import { User } from 'src/app/Models/user-model';
import { Mentor } from 'src/app/Models/mentor-model';
import { SkillService } from 'src/app/Services/skill.service';
import { Router } from '@angular/router';
import { Skills } from 'src/app/Models/skill-model';

@Component({
  selector: 'app-admindashboard',
  templateUrl: './admindashboard.component.html',
  styleUrls: ['./admindashboard.component.css']
})
export class AdmindashboardComponent implements OnInit {
  item1:User;
  list1:User[];
  item2:Mentor;
  list2:Mentor[];
  item3:Skills;
  item4:Skills;
  list3:Skills[];
  value="";
  msg:string;
  status:string;
  blocksts="";
  

  constructor(private service:UserService,private service1:MentorService,private fb:FormBuilder,private service2:SkillService,private router:Router) {
    this.item3=new Skills();
    this.item4=new Skills();
   }

  ngOnInit() {
  
   
  }
  

  User(){
    this.value="User";
    this.service.GetUsers().subscribe(k=>this.list1=k)
  }
  Mentor(){
    this.value="Mentor"
    this.service1.GetMentors().subscribe(data=>this.list2=data)
  }
  Skill(){
    this.value="Skill"
    this.service2.GetTechnology().subscribe(data=>this.list3=data)

  }
 DeleteUser(uid:string)
 {
  this.service.Delete(uid).subscribe(k=>k=this.msg)
  alert('Successfully Deleted!!\n\n');
 }

 DeleteMentor(mid:string)
 {
  this.service1.Delete(mid).subscribe(k=>k=this.msg)  
    alert('Successfully Deleted!!\n\n');
 }

 EditSkill()
 {
  this.service2.Update(this.item4).subscribe(k=>this.msg=k)
  console.log(this.msg);
  alert('Successfully Updated!!\n\n');
 }

BlockUser(id:string){
  this.service.BlockUser(id).subscribe(k=>k=this.msg)
}

BlockMentor(id:string){
  this.service1.BlockMentor(id).subscribe(k=>k=this.msg)
}
 
 DeleteSkill(sid:string)
 {
  this.service2.Delete(sid).subscribe(k=>k=this.msg)
  alert('Successfully Deleted!!\n\n');
 }

 GetSkillById(sid:string)
 {
  this.service2.Search(sid).subscribe(k=>this.item3=k)
 }
 
AddSkill()
{
  this.service2.Add(this.item3).subscribe(k=>k=this.msg);
  alert('Successfully Added!!\n\n');
}

reloadPage(){
  this.ngOnInit();
}

  check(){
    if(this.value=="User"){
      return 1;
    }
    else if(this.value=="Mentor"){
      return 2;
    }
    else if(this.value=="Skill"){
      return 3;
    }
    else return 4;
  }
}
