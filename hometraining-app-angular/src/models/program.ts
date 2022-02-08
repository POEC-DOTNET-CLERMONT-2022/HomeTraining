import {Exercice} from "./exercice";

export class Program {

  private _id: string = '';
  private _name:string='';
  private _created:Date;
  private _difficulty:number=0;
  private _userId:string='';
  private _exercices:Exercice[]=[];

  constructor(id:string, name: string, created: Date,difficulty:number, userId: string,exercices:Exercice[]) {
    this._id=id;
    this._name = name;
    this._created = created;
    this._difficulty =difficulty;
    this._userId = userId;
    this._exercices = exercices;
  }

  get id(): string {
    return this._id;
  }

  set id(value: string) {
    this._id = value;
  }

  get name(): string {
    return this._name;
  }

  set name(value: string) {
    this._name = value;
  }

  get created(): Date {
    return this._created;
  }

  set created(value: Date) {
    this._created = value;
  }

  get difficulty(): number {
    return this._difficulty;
  }

  set difficulty(value: number) {
    this._difficulty = value;
  }

  get userId(): string {
    return this._userId;
  }

  set userId(value: string) {
    this._userId = value;
  }

  get exercices(): Exercice[] {
    return this._exercices;
  }

  set exercices(value: Exercice[]) {
    this._exercices = value;
  }
}
