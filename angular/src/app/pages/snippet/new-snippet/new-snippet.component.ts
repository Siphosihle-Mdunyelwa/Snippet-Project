import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { AppComponentBase } from '@shared/app-component-base';
import { Component, OnInit, ViewChild, ElementRef, Injector } from '@angular/core';

@Component({
  selector: 'app-new-snippet',
  templateUrl: './new-snippet.component.html',
  styleUrls: ['./new-snippet.component.scss']
})
export class NewSnippetComponent extends AppComponentBase implements OnInit {

  @ViewChild('newSnippet') newSnippet: ElementRef;
  newSnippetForm: FormGroup;

  constructor(
    Injector: Injector,
    private modalService: NgbModal,
    private fb: FormBuilder) {
    super(Injector);
  }

  ngOnInit() {
    this.InitializeForm();
  }

  InitializeForm() {
    this.newSnippetForm = this.fb.group({
      name: ['', Validators.required],
      description: ['', Validators.required],
      category: ['', Validators.required],
      code: ['', Validators.required]
    })
  }

  show() {
    this.modalService.open(this.newSnippet, { size: 'lg' })
  }

  save() {
    this.notify.success('Created new Snippet');
  }

}
