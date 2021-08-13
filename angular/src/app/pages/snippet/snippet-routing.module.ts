import { NewSnippetComponent } from './new-snippet/new-snippet.component';
import { SnippetComponent } from './snippet.component';
import { RouterModule, Routes } from '@angular/router';

import { NgModule } from '@angular/core';

const routes: Routes = [
  { path: '', component: SnippetComponent },
  {
    path: 'new-snippet', component: NewSnippetComponent
  }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SnippetRoutingModule {

}
