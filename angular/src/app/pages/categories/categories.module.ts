import { HighlightModule, HighlightOptions, HIGHLIGHT_OPTIONS } from 'ngx-highlightjs';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NewCategoryComponent } from './new-category/new-category.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoriesComponent } from './categories.component';
import { CategoriesRoutingModule } from './categories-routing.module';
import { CategoryDetailsComponent } from './category-details/category-details.component';

import * as hljs from 'highlight.js';
document.defaultView['hljs'] = hljs;
import 'highlightjs-line-numbers.js';

@NgModule({
  declarations: [
    CategoriesComponent,
    NewCategoryComponent,
    CategoryDetailsComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    CategoriesRoutingModule,
    HighlightModule
  ],
  providers: [
    {
      provide: HIGHLIGHT_OPTIONS,
      useValue: <HighlightOptions>{
        lineNumbers: true,
        // The following is just a workaround to activate the line numbers script since dynamic import does not work in Stackblitz
        lineNumbersLoader: () => null
      }
    }
  ],
  entryComponents: [NewCategoryComponent]
})
export class CategoriesModule { }
