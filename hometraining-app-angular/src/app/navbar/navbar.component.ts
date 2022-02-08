import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {
  static pathMain : string = 'main';
  urlMain: string = '/' + NavbarComponent.pathMain;


  static pathExercices : string = 'exercices';
  urlExercices: string = '/' + NavbarComponent.pathExercices;

  static pathCreateUser : string = 'createUser';
  urlCreateUser: string = '/' + NavbarComponent.pathCreateUser;


  constructor(private router: Router) {

  }

  ngOnInit(): void {
  }

}
