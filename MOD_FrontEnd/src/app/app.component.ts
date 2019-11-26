import { Component } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MOD-ANGULAR';
 submitted=false;
  m: string;

ngOnInit(){


}
isLogin(){
  if(localStorage.getItem('login')=="yes")
  {
    this.m=localStorage.getItem("msg");
    return true;
  }
  else
  return false;
}
logoutUser(){
  localStorage.removeItem('login')
  localStorage.removeItem('msg')
  localStorage.removeItem('token')
  localStorage.removeItem('active');
  localStorage.removeItem('userId')

}
}
