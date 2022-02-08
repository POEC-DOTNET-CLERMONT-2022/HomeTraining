import {Guid} from "guid-typescript";

export class User {

  private _id: Guid;
  private _firstName:string='';
  private _lastName:string='';
  private _login:string='';
  private _password:string='';
  private _isAdmin:boolean=false;

  constructor(id:Guid, firstName: string, lastName: string,login:string, password: string,isAdmin:boolean) {
    this._id=id;
    this._firstName = firstName;
    this._lastName = lastName;
    this._login =login;
    this._password = password;
    this._isAdmin = isAdmin;
  }


  get id(): Guid {
    return this._id;
  }

  set id(value: Guid) {
    this._id = value;
  }

  get firstName(): string {
    return this._firstName;
  }

  set firstName(value: string) {
    this._firstName = value;
  }

  get lastName(): string {
    return this._lastName;
  }

  set lastName(value: string) {
    this._lastName = value;
  }

  get login(): string {
    return this._login;
  }

  set login(value: string) {
    this._login = value;
  }

  get password(): string {
    return this._password;
  }

  set password(value: string) {
    this._password = value;
  }

  get isAdmin(): boolean {
    return this._isAdmin;
  }

  set isAdmin(value: boolean) {
    this._isAdmin = value;
  }
}
