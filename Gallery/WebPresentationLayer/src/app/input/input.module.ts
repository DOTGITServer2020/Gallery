import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InputRoutingModule } from './input-routing.module';
import { InputComponent } from './input.component';
import { AddNewEmployeeComponent } from './HumanResource/add-new-employee/add-new-employee.component';
import { DemoMaterialModule } from '../material-module';
import { NgSelectModule } from '@ng-select/ng-select';
import { FormsModule } from '@angular/forms';
@NgModule({
  declarations: [InputComponent, AddNewEmployeeComponent],
  imports: [
    CommonModule,
    InputRoutingModule,
    DemoMaterialModule,
    NgSelectModule,
    FormsModule
  ]
})
export class InputModule { }
