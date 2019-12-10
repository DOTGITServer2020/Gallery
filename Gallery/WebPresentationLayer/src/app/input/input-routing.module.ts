import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { InputComponent } from './input.component';
import { AddNewEmployeeComponent } from './HumanResource/add-new-employee/add-new-employee.component';
const routes: Routes = [{ path: 'AddNewEmployee', component: AddNewEmployeeComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InputRoutingModule { }
