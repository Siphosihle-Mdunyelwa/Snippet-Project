import { NewUserComponent } from './new-user/new-user.component';
import { DecimalPipe } from '@angular/common';
import { Component, OnInit, QueryList, ViewChild, ViewChildren } from '@angular/core';
import { Observable } from 'rxjs';
import { AdvancedSortableDirective, SortEvent } from '../ui/tables/advanced/advanced-sortable.directive';
import { Table } from '../ui/tables/advanced/advanced.model';
import { AdvancedService } from '../ui/tables/advanced/advanced.service';

import { tableData, roles } from './data';
import { EditUserComponent } from './edit-user/edit-user.component';


@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss'],
  providers: [AdvancedService, DecimalPipe]
})
export class UsersComponent implements OnInit {

  @ViewChild('newUserModal') newUserModal: NewUserComponent;
  @ViewChild('editUserModal') editUserModal: EditUserComponent;

  breadCrumbItems: Array<{}>;

  // Table data
  tableData: Table[];

  tables$: Observable<Table[]>;
  total$: Observable<number>;

  @ViewChildren(AdvancedSortableDirective) headers: QueryList<AdvancedSortableDirective>;

  constructor(public service: AdvancedService) {
    this.tables$ = service.tables$;
    this.total$ = service.total$;
  }

  ngOnInit(): void {
    this.breadCrumbItems = [{ label: 'Snippet', path: '/' }, { label: 'Users', path: '/', active: true }];

    /**
     * fetch data
     */
    this._fetchData();
  }

  _fetchData() {
    this.tableData = tableData;
  }

  onSort({ column, direction }: SortEvent) {
    // resetting other headers
    this.headers.forEach(header => {
      if (header.sortable !== column) {
        header.direction = '';
      }
    });
    this.service.sortColumn = column;
    this.service.sortDirection = direction;
  }

  newUser() {
    this.newUserModal.show();
  }

  editUser() {
    this.editUserModal.show();
  }

}
