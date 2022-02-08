import {Component, Input, OnInit} from '@angular/core';
import {Guid} from "guid-typescript";
import {User} from "../../models/user";
import {UserService} from "../../servivces/user.service";

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.scss']
})
export class UserComponent implements OnInit {
 public user:User = new User(Guid.create(),"","","","",false);
 @Input()
 id!:string;

  constructor(private userService : UserService) {

  }

  ngOnInit(): void {
    console.log(this.id);
    this.userService.getUser(this.id).subscribe((user)=>{
      this.user=user;
    })
  }

}
