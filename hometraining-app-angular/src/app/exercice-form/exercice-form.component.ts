import {Component, OnInit} from '@angular/core';
import {Exercice} from "../../models/exercice";
import {ExerciceService} from "../../servivces/exercice.service";
import {MuscleArea, MuscleAreLabelMapping} from "../../models/MuscleArea";
import {Guid} from "guid-typescript";

@Component({
  selector: 'app-exercice-form',
  templateUrl: './exercice-form.component.html',
  styleUrls: ['./exercice-form.component.scss']
})
export class ExerciceFormComponent implements OnInit {
  exercice : Exercice=new Exercice(Guid.create(),"","",0,"",Guid.create());

  muscleArea = [
    {id: 0, name: "Epaules"},
    {id: 1, name: "Abdos"},
    {id: 2, name: "Jambes"},
    {id: 3, name: "Bras"},
    {id: 4, name: "Pectoraux"},
    {id: 5, name: "Dos"}
  ];
  errorMessage:string='';
  area:number=0;

  constructor(private exerciceService:ExerciceService) { }

  ngOnInit(): void {

  }


  onSubmit(): void {
    this.exercice.muscleArea=this.area;
    this.exerciceService.postExercice(this.exercice).subscribe({
      error: error => {
        this.errorMessage = error.message;
        console.error('There was an error!', error);
      }
    }
    );
    window.location.reload();

  }

}
