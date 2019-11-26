import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { UserRegisterComponent } from './Components/User/user-register/user-register.component';
import { MentorRegisterComponent } from './Components/Mentor/mentor-register/mentor-register.component';
import { LoginComponent } from './Components/login/login.component';
import { UserdashboardComponent } from './Components/User/userdashboard/userdashboard.component';
import { CoursesComponent } from './Components/Homepage/courses/courses.component';
import { AdmindashboardComponent } from './Components/admindashboard/admindashboard.component';
import { MentordashboardComponent } from './Components/Mentor/mentordashboard/mentordashboard.component';
import { HomeComponent } from './Components/Homepage/home/home.component';
import { AboutComponent } from './Components/Homepage/about/about.component';


const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'Home',component:HomeComponent},
  {path:'About',component:AboutComponent},
  {path:'Signup/User',component:UserRegisterComponent},
  {path:'Signup/Mentor',component:MentorRegisterComponent},
  {path:'Login',component:LoginComponent}, 
  {path:'userdashboard',component:UserdashboardComponent},
  {path:'mentordashboard',component:MentordashboardComponent},
  {path:'admindashboard',component:AdmindashboardComponent},
  {path:'courses',component:CoursesComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
