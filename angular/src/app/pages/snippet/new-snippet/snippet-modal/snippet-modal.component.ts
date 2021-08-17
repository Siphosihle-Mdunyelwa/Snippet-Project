import { AppComponentBase } from '@shared/app-component-base';
import { Component, ElementRef, Injector, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-snippet-modal',
  templateUrl: './snippet-modal.component.html',
  styleUrls: ['./snippet-modal.component.scss']
})
export class SnippetModalComponent extends AppComponentBase implements OnInit {

  @ViewChild('newSnippet') newSnippet: ElementRef;
  newSnippetForm: FormGroup;

  constructor(
    injector: Injector,
    private modalService: NgbModal,
    private fb: FormBuilder) {
    super(injector);
  }

  ngOnInit() {
    this.initializeForm();
  }

  initializeForm() {
    this.newSnippetForm = this.fb.group({
      code: ['', Validators.required]
    });

  }

  show() {
    this.modalService.open(this.newSnippet)
  }

  save() {
    this.notify.success('Created Successfully');
  }

}
