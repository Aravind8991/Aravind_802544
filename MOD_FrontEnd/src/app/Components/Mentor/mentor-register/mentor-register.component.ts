import { Component, OnInit } from '@angular/core';
import { MentorService } from 'src/app/Services/mentor.service';
import { Mentor } from 'src/app/Models/mentor-model';
import {Router} from '@angular/router';
import { FormGroup, FormBuilder,Validators } from '@angular/forms';
import { SkillService } from 'src/app/Services/skill.service';
import { Skills } from 'src/app/Models/skill-model';

@Component({
  selector: 'app-mentor-register',
  templateUrl: './mentor-register.component.html',
  styleUrls: ['./mentor-register.component.css']
})
export class MentorRegisterComponent implements OnInit {
 
  item:Mentor;
  list:Mentor[];
  item1:Skills;
  list1:Skills[];
  msg:any;
  registerForm: FormGroup;
  submitted = false;
  constructor(private _service:MentorService,private formBuilder: FormBuilder,private router:Router,private myservice:SkillService) {
    this.item = new Mentor();
   }
   ngOnInit() { 
    this.registerForm = this.formBuilder.group({
       
      mentorName: ['', [Validators.required, Validators.maxLength(15),Validators.pattern('^[a-zA-Z ]*$')]],
       email: ['', [Validators.required, Validators.email]],
       password: ['', [Validators.required, Validators.minLength(5)]],
       skill: ['', Validators.required],
       experience: ['', Validators.required],
       timeSlot: ['', Validators.required],
       availability: ['', Validators.required],
       mobileNo: ['', [Validators.required,Validators.pattern("^[0-9]*$"), Validators.minLength(10)]]

     }
     );
 this.myservice.GetTechnology().subscribe(data=>this.list1=data);
    }
 get for() { return this.registerForm.controls; }

  
  onSubmit(){
    this.submitted = true;

    // stop here if form is invalid
    if (this.registerForm.invalid) {
        return;
    }
    else{
      this._service.Add(this.item).subscribe(k=>this.msg=k);
      console.log(this.msg);
    this.router.navigate(['/Login']);
  }
}
}
  