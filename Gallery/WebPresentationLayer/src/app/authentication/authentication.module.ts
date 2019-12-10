import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { DemoMaterialModule } from '../material-module';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HttpClient } from '@angular/common/http';
@NgModule({
  declarations: [LoginComponent],
  imports: [
    CommonModule,
    DemoMaterialModule,
    FormsModule,HttpClientModule
  ]
})
export class AuthenticationModule { }
