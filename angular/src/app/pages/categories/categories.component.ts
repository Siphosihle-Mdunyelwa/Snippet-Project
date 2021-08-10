import { NewCategoryComponent } from './new-category/new-category.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Component, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {

  @ViewChild('newCategoryModal') newCategoryModal: NewCategoryComponent;
  constructor() { }

  ngOnInit(): void {
  }

  newCategory() {
    this.newCategoryModal.show();
  }
}
