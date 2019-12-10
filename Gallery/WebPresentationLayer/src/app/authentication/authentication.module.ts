import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { DemoMaterialModule } from '../material-module';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [LoginComponent],
  imports: [
    CommonModule,
    DemoMaterialModule,
    FormsModule
  ]
})
export class AuthenticationModule { }
