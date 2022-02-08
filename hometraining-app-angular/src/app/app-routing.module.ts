import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {NavbarComponent} from "./navbar/navbar.component";
import {ExerciceFormComponent} from "./exercice-form/exercice-form.component";
import {ExercicesViewComponent} from "./exercices-view/exercices-view.component";
import {UserFormComponent} from "./user-form/user-form.component";

const routes: Routes = [
  {path: NavbarComponent.pathMain, component: ExerciceFormComponent},
  {path: NavbarComponent.pathExercices, component: ExercicesViewComponent},
  {path: NavbarComponent.pathCreateUser, component: UserFormComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
