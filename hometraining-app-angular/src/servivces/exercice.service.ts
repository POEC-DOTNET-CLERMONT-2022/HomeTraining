import { Injectable } from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http';
import {Observable, throwError} from "rxjs";
import {Exercice} from "../models/exercice";
import {Guid} from "guid-typescript";

@Injectable({
  providedIn: 'root'
})
export class ExerciceService {
  private exercicesUrl = 'https://localhost:7266/api/Exercices';
  headers: {headers: HttpHeaders} = {
    headers: new HttpHeaders({
      'Content-Type': 'application/ld+json;charset=utf-8',
    })
  };

  constructor(private http: HttpClient) {

  }


  getExercices(): Observable<Exercice[]> {
    return this.http.get<Exercice[]>(this.exercicesUrl);
  }

  postExercice(exercice: Exercice):  Observable<Exercice>{

    const body ={
      "id": exercice.id.toString(),
      "name": exercice.name,
      "description": exercice.description,
      "muscleArea": exercice.muscleArea,
      "videoName": exercice.videoName,
      "userId": "da286a18-43c9-51f1-1eba-a76d2ac0b1dc"
    };
    console.log(exercice);
    console.log(body);
    return this.http.post<Exercice>(
      this.exercicesUrl,
      body,
      this.headers);
  }

  deleteExercice(id:string): Observable<Exercice> {
    return this.http.delete<Exercice>(this.exercicesUrl+"/"+id);
  }

  putExercice(exercice:Exercice): Observable<Exercice> {
    const body ={
      "id": exercice.id.toString(),
      "name": exercice.name,
      "description": exercice.description,
      "muscleArea": exercice.muscleArea,
      "videoName": exercice.videoName,
      "userId": "da286a18-43c9-51f1-1eba-a76d2ac0b1dc"
    };
    return this.http.put<Exercice>(this.exercicesUrl+"/"+exercice.id.toString(),body,this.headers);
  }

}
