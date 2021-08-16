import { NewSnippetComponent } from './new-snippet/new-snippet.component';
import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { HighlightResult } from 'ngx-highlightjs';



@Component({
  selector: 'app-snippet',
  templateUrl: './snippet.component.html',
  styleUrls: ['./snippet.component.scss']
})
export class SnippetComponent implements OnInit {

  @ViewChild('newSnippetModal') newSnippetModal: NewSnippetComponent;

  response: HighlightResult;
  code = `// Instantiate random number generator
  private readonly Random _random = new Random();

  // Generates a random number within a range
  public int RandomNumber(int min, int max)
  {
    return _random.Next(min, max);
  }`;

  code1 = `function largestOfFour(arr) {
    let answer = []
    for (let i = 0; i < arr.length; i++) {
      answer.push(Math.max(...arr[i]))
    }

    return answer
  }
  largestOfFour([[4, 5, 1, 3], [13, 27, 18, 26], [32, 35, 37, 39], [1000, 1001, 857, 1]]);
  `;

  constructor(private router: Router) { }

  ngOnInit(): void {

  }

  newSnippet() {
    this.router.navigate(['/snippets/new-snippet'])
    // this.newSnippetModal.show();
  }

  loadCard() {
    this.router.navigate(['/snippets/all-snippets/'])
  }

  onHighlight(e: any) {
    this.response = {
      language: e.language,
      relevance: e.relevance,
      second_best: '{...}',
      top: '{...}',
      value: '{...}'
    }
  }

}
