import { SnippetModalComponent } from './new-snippet/snippet-modal/snippet-modal.component';
import { AllSnippetsComponent } from './all-snippets/all-snippets.component';
import { HighlightModule, HighlightOptions, HIGHLIGHT_OPTIONS } from 'ngx-highlightjs';
import { NewSnippetComponent } from './new-snippet/new-snippet.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SnippetComponent } from './snippet.component';
import { SnippetRoutingModule } from './snippet-routing.module';
import { UIModule } from '@app/shared/ui/ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import * as hljs from 'highlight.js';
document.defaultView['hljs'] = hljs;
import 'highlightjs-line-numbers.js';

@NgModule({
  declarations: [
    SnippetComponent,
    NewSnippetComponent,
    AllSnippetsComponent,
    SnippetModalComponent
  ],
  imports: [
    CommonModule,
    SnippetRoutingModule,
    UIModule,
    FormsModule,
    ReactiveFormsModule,
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
})
export class SnippetModule { }
