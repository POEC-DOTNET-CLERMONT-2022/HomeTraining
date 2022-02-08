import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {Observable} from "rxjs";
import {User} from "../models/user";
import {Guid} from "guid-typescript";

@Injectable({
  providedIn: 'root'
})
export class UserService {
  private usersUrl = 'https://localhost:7266/api/User/';
  headers: {headers: HttpHeaders} = {
    headers: new HttpHeaders({
      'Content-Type': 'application/ld+json;charset=utf-8',
    })
  };

  constructor(private http: HttpClient) {

  }


  getUsers(): Observable<User[]> {
    return this.http.get<User[]>(this.usersUrl);
  }

  getUser(id:string): Observable<User> {
    return this.http.get<User>(this.usersUrl+id);
  }

  postUser(user: User):  Observable<User>{

    const body ={
      "id": user.id.toString(),
      "firstName": user.firstName,
      "lastName": user.lastName,
      "login": user.login,
      "password": user.password,
      "isAdmin": user.isAdmin
    };
    console.log(user);
    console.log(body);
    return this.http.post<User>(
      this.usersUrl,
      body,
      this.headers);
  }

  deleteUser(id:string): Observable<User> {
    return this.http.get<User>(this.usersUrl+id);
  }

  putUser(id:string): Observable<User> {
    return this.http.get<User>(this.usersUrl+id);
  }
}
