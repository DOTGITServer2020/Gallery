import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
@Component({
  selector: 'app-add-new-user',
  templateUrl: './add-new-user.component.html',
  styleUrls: ['./add-new-user.component.scss']
})
export class AddNewUserComponent implements OnInit {

  
  constructor(private router: Router) { }

  ngOnInit() {

  }

  login(){
    this.router.navigateByUrl('/AddNewUser');
  }


}
