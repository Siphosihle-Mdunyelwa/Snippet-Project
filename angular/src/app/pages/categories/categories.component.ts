import { HttpClient } from '@angular/common/http';
import { CategoryDto, CategoryServiceProxy, ListCategoryDto } from '@shared/service-proxies/service-proxies';
import { Router } from '@angular/router';
import { NewCategoryComponent } from './new-category/new-category.component';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Component, OnInit, ViewChild } from '@angular/core';
import { tap } from 'rxjs/operators';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.scss']
})
export class CategoriesComponent implements OnInit {
  @ViewChild('newCategoryModal') newCategoryModal: NewCategoryComponent;

  categories: CategoryDto[] = [];

  constructor(
    private router: Router,
    private categoriesService: CategoryServiceProxy,
    private http: HttpClient) { }

  ngOnInit(): void {
    // this.categoriesService.get('15AB7842-6286-4C1E-F3A2-08D96189064A').subscribe((response) => {
    //   // this.categories = response.items;
    //   console.log(response);
    // })
    this.getCategories();
  }

  getCategories() {
    this.http.get<any>('http://localhost:21021/api/services/app/Category/GetAll')
      .subscribe(data => {
        this.categories = data.result.items;
      });
  }

  loadSnippets() {
    this.router.navigate(['categories/category-snippets/'])
  }

  newCategory() {
    this.newCategoryModal.show();
  }
}
