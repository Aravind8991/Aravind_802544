import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserRegisterComponent } from './Components/User/user-register/user-register.component';
import {  UserService } from './Services/user.service';
import{HttpClient,HttpClientModule}from "@angular/common/http";
import {FormsModule,ReactiveFormsModule}from "@angular/forms";
import { MentorRegisterComponent } from './Components/Mentor/mentor-register/mentor-register.component';
import { MentorService } from './Services/mentor.service';
import { LoginComponent } from './Components/login/login.component';
import { LoginService } from './Services/login.service';
import { MentordashboardComponent } from './Components/Mentor/mentordashboard/mentordashboard.component';
import { UserdashboardComponent } from './Components/User/userdashboard/userdashboard.component';
import { CoursesComponent } from './Components/Homepage/courses/courses.component';
import { AdmindashboardComponent } from './Components/admindashboard/admindashboard.component';
import { HomeComponent } from './Components/Homepage/home/home.component';
import { AboutComponent } from './Components/Homepage/about/about.component';


@NgModule({
  declarations: [
    AppComponent,
    UserRegisterComponent,
    MentorRegisterComponent,
    LoginComponent,
    MentordashboardComponent,
    UserdashboardComponent,
    CoursesComponent,
    AdmindashboardComponent,
    HomeComponent,
    AboutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,HttpClientModule,FormsModule,ReactiveFormsModule
  ],
  providers: [UserService,MentorService,LoginService],
  bootstrap: [AppComponent]
})
export class AppModule { }
