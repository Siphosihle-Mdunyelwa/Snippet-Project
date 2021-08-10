import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NewCategoryComponent } from './new-category/new-category.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoriesComponent } from './categories.component';
import { CategoriesRoutingModule } from './categories-routing.module';



@NgModule({
  declarations: [
    CategoriesComponent,
    NewCategoryComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    CategoriesRoutingModule
  ],
  entryComponents: [NewCategoryComponent]
})
export class CategoriesModule { }
