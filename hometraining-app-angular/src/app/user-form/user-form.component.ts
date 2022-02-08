import { Component, OnInit } from '@angular/core';
import {Guid} from "guid-typescript";
import {User} from "../../models/user";
import {UserService} from "../../servivces/user.service";

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.scss']
})
export class UserFormComponent implements OnInit {
  user : User=new User(Guid.create(),"","","","",false);

  constructor(public userService:UserService) { }

  ngOnInit(): void {

  }

  onSubmit(): void {
    this.userService.postUser(this.user).subscribe((User) => {

    });
  }


}
