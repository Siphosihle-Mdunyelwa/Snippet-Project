import { CategorySnippetsComponent } from './category-snippets/category-snippets.component';
import { CategoriesComponent } from './categories.component';
import { RouterModule, Routes } from '@angular/router';

import { NgModule } from '@angular/core';

const routes: Routes = [
  { path: '', component: CategoriesComponent },
  { path: 'category-snippets', component: CategorySnippetsComponent }
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CategoriesRoutingModule {

}
