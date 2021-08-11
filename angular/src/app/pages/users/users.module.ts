import { NewUserComponent } from './new-user/new-user.component';
import { CommonModule } from '@angular/common';
import { UsersComponent } from './users.component';
import { NgModule } from '@angular/core';
import { UsersRoutingModule } from './users-routing.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbPaginationModule, NgbTypeaheadModule } from '@ng-bootstrap/ng-bootstrap';
import { UIModule } from '@app/shared/ui/ui.module';


@NgModule({
  declarations: [
    UsersComponent,
    NewUserComponent
  ],
  imports: [
    CommonModule,
    UIModule,
    UsersRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    NgbPaginationModule,
    NgbTypeaheadModule
  ]
})

export class UsersModule { }
