import { HttpClient } from '@angular/common/http';
import { CategoryServiceProxy, CategoryDto, CreateSnippetInput, SnippetServiceProxy } from './../../../../shared/service-proxies/service-proxies';
import { SnippetModalComponent } from './snippet-modal/snippet-modal.component';

import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AppComponentBase } from '@shared/app-component-base';
import { Component, OnInit, ViewChild, ElementRef, Injector } from '@angular/core';
import { HighlightResult } from 'ngx-highlightjs';
import { OperatorFunction, Observable } from 'rxjs';
import { debounceTime, distinctUntilChanged, map } from 'rxjs/operators';
import { LogLevel } from '@aspnet/signalr';
const states = ['Alabama', 'Alaska', 'American Samoa', 'Arizona', 'Arkansas', 'California', 'Colorado',
  'Connecticut', 'Delaware', 'District Of Columbia', 'Federated States Of Micronesia', 'Florida', 'Georgia',
  'Guam', 'Hawaii', 'Idaho', 'Illinois', 'Indiana', 'Iowa', 'Kansas', 'Kentucky', 'Louisiana', 'Maine',
  'Marshall Islands', 'Maryland', 'Massachusetts', 'Michigan', 'Minnesota', 'Mississippi', 'Missouri', 'Montana',
  'Nebraska', 'Nevada', 'New Hampshire', 'New Jersey', 'New Mexico', 'New York', 'North Carolina', 'North Dakota',
  'Northern Mariana Islands', 'Ohio', 'Oklahoma', 'Oregon', 'Palau', 'Pennsylvania', 'Puerto Rico', 'Rhode Island',
  'South Carolina', 'South Dakota', 'Tennessee', 'Texas', 'Utah', 'Vermont', 'Virgin Islands', 'Virginia',
  'Washington', 'West Virginia', 'Wisconsin', 'Wyoming'];
@Component({
  selector: 'app-new-snippet',
  templateUrl: './new-snippet.component.html',
  styleUrls: ['./new-snippet.component.scss'],
  providers: [CategoryServiceProxy]
})
export class NewSnippetComponent extends AppComponentBase implements OnInit {
  @ViewChild('newSnippetModal') newSnippetModal: SnippetModalComponent;
  newSnippetForm: FormGroup;
  input = new CreateSnippetInput();
  response: HighlightResult;
  categories: CategoryDto[] = [];
  selectedCategory: any;
  code = '';


  constructor(
    Injector: Injector,
    private modalService: NgbModal,
    private categoryService: CategoryServiceProxy,
    private snippetService: SnippetServiceProxy,
    private fb: FormBuilder,
    private http: HttpClient) {
    super(Injector);
  }

  ngOnInit() {
    this.InitializeForm();
    this.getCategories();
  }
  search: OperatorFunction<string, readonly string[]> = (text$: Observable<string>) =>
    text$.pipe(
      debounceTime(200),
      distinctUntilChanged(),
      map(term => term.length < 2 ? []
        : states.filter(v => v.toLowerCase().indexOf(term.toLowerCase()) > -1).slice(0, 10))
    )

  getCategories() {
    this.http.get<any>('http://localhost:21021/api/services/app/Category/GetAll')
      .subscribe(data => {
        this.categories = data.result.items;
        console.log(this.categories);
      });
  }

  InitializeForm() {
    this.newSnippetForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      categoryId: ['', Validators.required],
      topicId: [''],
    })
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

  onSnippetAdded(code: string) {
    this.code = code;
  }

  get form() {
    return this.newSnippetForm.controls;
  }

  newSnippet() {
    this.newSnippetModal.show();
  }

  save() {
    this.input = this.newSnippetForm.value;
    this.input.code = this.code;
    this.snippetService.create(this.input)
      .subscribe(() => {
        this.notify.success('Created Successfully');
      }, error => {
        this.notify.error('An Error Occurred');
        console.log(error);
      });
  }

}
