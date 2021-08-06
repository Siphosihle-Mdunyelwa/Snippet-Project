import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { SnippsComponent } from './snipps.component';

const routes: Routes = [
  { path: '', component: SnippsComponent }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class SnippsRoutingModule { }
