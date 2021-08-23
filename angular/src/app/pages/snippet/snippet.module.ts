import { NgSelectModule } from '@ng-select/ng-select';
import { SnippetModalComponent } from './new-snippet/snippet-modal/snippet-modal.component';
import { AllSnippetsComponent } from './all-snippets/all-snippets.component';
import { HighlightModule, HighlightOptions, HIGHLIGHT_OPTIONS } from 'ngx-highlightjs';
import { NewSnippetComponent } from './new-snippet/new-snippet.component';
import { NgModule } from '@angular/core';
import { CommonModule, NgClass } from '@angular/common';
import { SnippetComponent } from './snippet.component';
import { SnippetRoutingModule } from './snippet-routing.module';
import { UIModule } from '@app/shared/ui/ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import * as hljs from 'highlight.js';
document.defaultView['hljs'] = hljs;
import 'highlightjs-line-numbers.js';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { SnippetServiceProxy } from '@shared/service-proxies/service-proxies';

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
    NgbModule,
    FormsModule,
    ReactiveFormsModule,
    HighlightModule,
    NgSelectModule
  ],
  providers: [
    {
      provide: HIGHLIGHT_OPTIONS,
      useValue: <HighlightOptions>{
        lineNumbers: true,
        // The following is just a workaround to activate the line numbers script since dynamic import does not work in Stackblitz
        lineNumbersLoader: () => null
      }
    },
    SnippetServiceProxy
  ],
})
export class SnippetModule { }
