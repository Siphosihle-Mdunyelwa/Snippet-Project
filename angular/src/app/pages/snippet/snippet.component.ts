import { NewSnippetComponent } from './new-snippet/new-snippet.component';
import { Component, OnInit, ViewChild } from '@angular/core';



@Component({
  selector: 'app-snippet',
  templateUrl: './snippet.component.html',
  styleUrls: ['./snippet.component.scss']
})
export class SnippetComponent implements OnInit {

  @ViewChild('newSnippetModal') newSnippetModal: NewSnippetComponent;

  constructor() { }

  ngOnInit(): void {


  }

  newSnippet() {
    this.newSnippetModal.show();
  }

}
