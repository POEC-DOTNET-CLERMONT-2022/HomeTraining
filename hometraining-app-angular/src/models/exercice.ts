import {Guid} from "guid-typescript";

export class Exercice {
  private _id: Guid;
  private _name:string='';
  private _description:string='';
  private _muscleArea:number=0;
  private _videoName:string='';
  private _userId:Guid;


  constructor(id:Guid, name: string, description: string,muscleArea:number,videoName:string, userId: Guid) {
    this._id=id;
    this._name = name;
    this._description = description;
    this._muscleArea=muscleArea;
    this._videoName =videoName;
    this._userId = userId;
  }

  get id(): Guid {
    return this._id;
  }

  set id(value: Guid) {
    this._id = value;
  }

  get name(): string {
    return this._name;
  }

  set name(value: string) {
    this._name = value;
  }

  get description(): string {
    return this._description;
  }

  set description(value: string) {
    this._description = value;
  }

  get muscleArea(): number {
    return this._muscleArea;
  }

  set muscleArea(value: number) {
    this._muscleArea = value;
  }

  get videoName(): string {
    return this._videoName;
  }

  set videoName(value: string) {
    this._videoName = value;
  }

  get userId(): Guid {
    return this._userId;
  }

  set userId(value: Guid) {
    this._userId = value;
  }
}
