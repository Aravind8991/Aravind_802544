import { Component, OnInit } from '@angular/core';
import { LoginService } from 'src/app/Services/login.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  id;
  password;
  token:any;
  constructor(private _service:LoginService,private router:Router) { }




  ngOnInit() {
  }
  public Login(){
    this._service.Login(this.id,this.password).subscribe(data=>
      {
        console.log(data)
        if(data.message=="User"){        []
        alert('Successfull Login as User!!\n\n');
        this.router.navigate(['/userdashboard']);
        }
        else if(data.message=="Mentor")
        {
        alert('Successfull Login as Mentor!!\n\n');
        this.router.navigate(['/mentordashboard']);
        }

        else if(data.message=="Admin")
        {
        alert('Successfull Login as Admin!!\n\n');
        this.router.navigate(['/admindashboard']);
        }

        else
        {
        alert('Invalid Credentials!!\n\n');
        this.router.navigate(['/']);
        }

      });
 
  }
}



