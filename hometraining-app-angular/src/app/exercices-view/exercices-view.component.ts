import {Component, Input, OnInit} from '@angular/core';
import {ExerciceService} from "../../servivces/exercice.service";
import {Exercice} from "../../models/exercice";
import {Guid} from "guid-typescript";

@Component({
  selector: 'app-exercices-view',
  templateUrl: './exercices-view.component.html',
  styleUrls: ['./exercices-view.component.scss']
})
export class ExercicesViewComponent implements OnInit {

  public exercice!: Exercice;

  public listExercices: Array<Exercice> = new Array<Exercice>();


  constructor(public exerciceService: ExerciceService) {
  }

  ngOnInit(): void {
    this.exerciceService.getExercices().subscribe((exerciceList: Array<Exercice>) => {
      this.listExercices = exerciceList;
    });

  }

  delete(id: Guid) {
    this.exerciceService.deleteExercice(id.toString()).subscribe((deleted) => {
      this.listExercices = this.listExercices.filter((u) => u.id !== id)
    });
  }

  updateWindwow(exercice: Exercice) {
    this.exercice = exercice;
  }
}
