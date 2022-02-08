import {Exercice} from "./exercice";

export class ProgramExercice {

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


}
