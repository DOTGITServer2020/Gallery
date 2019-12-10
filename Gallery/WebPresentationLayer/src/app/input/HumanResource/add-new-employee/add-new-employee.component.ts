import { Component, OnInit } from '@angular/core';
import {NgSelectModule, NgOption} from '@ng-select/ng-select';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';


@Component({
  selector: 'app-add-new-employee',
  templateUrl: './add-new-employee.component.html',
  styleUrls: ['./add-new-employee.component.scss']
})
export class AddNewEmployeeComponent implements OnInit {
  isLinear = false;
  PersonalInformationFormGroup: FormGroup;
  RoleFormGroup: FormGroup;
  AccessFormGroup: FormGroup;
  ShiftFormGroup: FormGroup;
  ReportingHierarchyFormGroup: FormGroup;
  ProjectFormGroup: FormGroup;
  StatusRemarksFormGroup: FormGroup;

  // tslint:disable-next-line: variable-name
  constructor(private _formBuilder: FormBuilder) { }

  gender: any[] = [
  {id: 1, name: 'Male'},
  {id: 2, name: 'Female'},
  {id: 3, name: 'TransGender'}
];

  location: any[] = [
  {id: 1, name: 'Chennai'},
  {id: 2, name: 'Trichy'}
];

  ngOnInit() {
    this.PersonalInformationFormGroup = this._formBuilder.group({
      PersonalInformationCtrl: ['', Validators.required]
    });
    this.RoleFormGroup = this._formBuilder.group({
      RoleCtrl: ['', Validators.required]
    });
    this.AccessFormGroup = this._formBuilder.group({
      AccessCtrl: ['', Validators.required]
    });
    this.ShiftFormGroup = this._formBuilder.group({
      ShiftCtrl: ['', Validators.required]
    });
    this.ReportingHierarchyFormGroup = this._formBuilder.group({
      ReportingHierarchyCtrl: ['', Validators.required]
    });
    this.ProjectFormGroup = this._formBuilder.group({
      ProjectCtrl: ['', Validators.required]
    });
    this.StatusRemarksFormGroup = this._formBuilder.group({
      StatusRemarksCtrl: ['', Validators.required]
    });
  }



}
