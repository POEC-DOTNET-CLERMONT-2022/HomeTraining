import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './user/user.component';
import { HttpClientModule } from '@angular/common/http';
import { ExerciceFormComponent } from './exercice-form/exercice-form.component';
import {FormsModule} from "@angular/forms";
import { NavbarComponent } from './navbar/navbar.component';
import { ExercicesViewComponent } from './exercices-view/exercices-view.component';
import { UserFormComponent } from './user-form/user-form.component';
import { UpdateExerciceComponent } from './update-exercice/update-exercice.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    ExerciceFormComponent,
    NavbarComponent,
    ExercicesViewComponent,
    UserFormComponent,
    UpdateExerciceComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,//obligatoire pour faire des requettes HTTP
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
