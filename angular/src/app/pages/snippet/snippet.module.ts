import { NewSnippetComponent } from './new-snippet/new-snippet.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SnippetComponent } from './snippet.component';
import { SnippetRoutingModule } from './snippet-routing.module';
import { UIModule } from '@app/shared/ui/ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    SnippetComponent,
    NewSnippetComponent
  ],
  imports: [
    CommonModule,
    SnippetRoutingModule,
    UIModule,
    FormsModule,
    ReactiveFormsModule

  ]
})
export class SnippetModule { }
