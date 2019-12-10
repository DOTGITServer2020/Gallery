import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import * as _ from 'lodash';
import { AuthService } from '../login/service/auth.service';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  constructor(private router: Router , private authService: AuthService) { }
  IsLoggedIn = false;
  ngOnInit() {
  }

  Login() {
    this.IsLoggedIn = true;
    // this.router.navigateByUrl('Dot/HR/AddNewEmployee');
    this.authService.post().subscribe(res => {

    });
  }

  LoginBack() {
    this.IsLoggedIn = false;
    // this.router.navigateByUrl('Dot/HR/AddNewEmployee');
  }
}
