import { CommonModule } from '@angular/common';
import { UserComponent } from './user.component';
import { NgModule } from '@angular/core';
import { UserRoutingModule } from './user-routing.module';


@NgModule({
  declarations: [
    UserComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule
  ]
})

export class UserModule { }
