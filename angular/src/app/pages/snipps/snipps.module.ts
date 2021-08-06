import { CommonModule } from '@angular/common';
import { SnippsComponent } from './snipps.component';
import { NgModule } from '@angular/core';
import { SnippsRoutingModule } from './snipps-routing.module';


@NgModule({
  declarations: [
    SnippsComponent
  ],
  imports: [
    CommonModule,
    SnippsRoutingModule
  ]
})

export class SnippsModule { }
