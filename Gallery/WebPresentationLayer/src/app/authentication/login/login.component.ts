import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import * as _ from 'lodash';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(private router: Router) { }
  IsLoggedIn = false;
  ngOnInit() {
  }

  Login() {
    this.IsLoggedIn = true;
    // this.router.navigateByUrl('Dot/HR/AddNewEmployee');
  }

  LoginBack() {
    this.IsLoggedIn = false;
    // this.router.navigateByUrl('Dot/HR/AddNewEmployee');
  }
}
