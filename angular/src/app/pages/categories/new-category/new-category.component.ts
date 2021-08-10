import { AppComponentBase } from 'shared/app-component-base';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit, ViewChild, ElementRef, Injector } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-new-category',
  templateUrl: './new-category.component.html',
  styleUrls: ['./new-category.component.scss']
})
export class NewCategoryComponent extends AppComponentBase implements OnInit {

  @ViewChild('newCategory') newCategory: ElementRef;
  newCategoryForm: FormGroup;
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
    this.newCategoryForm = this.fb.group({
      name: ['', Validators.required]
    });

  }

  show() {
    this.modalService.open(this.newCategory, { size: 'sm' })
  }

  save() {
    this.notify.success('Created Successfully');
  }

}
