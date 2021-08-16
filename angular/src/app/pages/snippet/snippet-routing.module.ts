import { AllSnippetsComponent } from './all-snippets/all-snippets.component';
import { NewSnippetComponent } from './new-snippet/new-snippet.component';
import { SnippetComponent } from './snippet.component';
import { RouterModule, Routes } from '@angular/router';

import { NgModule } from '@angular/core';

const routes: Routes = [
  { path: '', component: SnippetComponent },
  {
    path: 'new-snippet', component: NewSnippetComponent
  },
  {
    path: 'all-snippets', component: AllSnippetsComponent
  },
  {
    path: 'snippet', component: SnippetComponent
  }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SnippetRoutingModule {

}
