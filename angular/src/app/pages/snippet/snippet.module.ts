import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SnippetComponent } from './snippet.component';
import { SnippetRoutingModule } from './snippet-routing.module';



@NgModule({
  declarations: [
    SnippetComponent
  ],
  imports: [
    CommonModule,
    SnippetRoutingModule
  ]
})
export class SnippetModule { }
