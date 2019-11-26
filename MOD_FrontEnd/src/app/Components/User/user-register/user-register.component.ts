import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/Models/user-model';
import{UserService}from 'src/app/Services/user.service'
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'app-user-register',
  templateUrl: './user-register.component.html',
  styleUrls: ['./user-register.component.css']
})
export class UserRegisterComponent implements OnInit {
  item:User;
  msg:any; 
  list:User[];
  registerForm: FormGroup;
  submitted = false;
  userId: any;
  constructor(private _service:UserService,private formBuilder: FormBuilder,private router:Router) {
    this.item = new User();
   }
ngOnInit() { 
  this.registerForm = this.formBuilder.group({
     
    userName: ['', [Validators.required, Validators.maxLength(15),Validators.pattern('^[a-zA-Z ]*$')]],
     email: ['', [Validators.required, Validators.email]],
     password: ['', [Validators.required, Validators.minLength(5)]],
     mobilNo: ['', [Validators.required,Validators.pattern("^[0-9]*$"), Validators.minLength(10)]]

   }
   );
}
get for() { return this.registerForm.controls; }


onSubmit(){
  this.submitted = true;

  // stop here if form is invalid
  if (this.registerForm.invalid) {
      return;
  }
  else{
    this._service.AddUser(this.item).subscribe(k=>this.msg=k);
    console.log(this.msg);
    alert("Note your UserId");
    alert(this.item.userId)
  this.router.navigate(['/Login']);
}
}
}
