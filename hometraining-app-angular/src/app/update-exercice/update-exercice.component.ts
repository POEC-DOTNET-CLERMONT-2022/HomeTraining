import {Component, Input, OnInit} from '@angular/core';
import {Exercice} from "../../models/exercice";
import {Guid} from "guid-typescript";
import {ExerciceService} from "../../servivces/exercice.service";

@Component({
  selector: 'app-update-exercice',
  templateUrl: './update-exercice.component.html',
  styleUrls: ['./update-exercice.component.scss']
})
export class UpdateExerciceComponent implements OnInit {
  @Input()
  exercice : any;
  public thearea:any;
  private errorMessage: any;
  muscleAreas = [
    {id: 0, name: "Epaules"},
    {id: 1, name: "Abdos"},
    {id: 2, name: "Jambes"},
    {id: 3, name: "Bras"},
    {id: 4, name: "Pectoraux"},
    {id: 5, name: "Dos"}
  ];


  constructor(private exerciceService:ExerciceService) { }

  ngOnInit(): void {
    this.thearea=this.exercice.muscleArea;
  }


  onSubmit() {
    this.exercice.muscleArea=this.thearea;
    console.log(this.exercice);
    this.exerciceService.putExercice(this.exercice).subscribe({
        error: error => {
          this.errorMessage = error.message;
          console.error('There was an error!', error);
        }
      }
    );
   // window.location.reload();
  }
}
