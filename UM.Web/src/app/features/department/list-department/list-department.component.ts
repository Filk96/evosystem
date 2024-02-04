import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DepartmenetModel } from 'src/app/core/model/department-model';
import { DepartmentService } from 'src/app/core/shared/services/department.service';

@Component({
  selector: 'app-list-department',
  templateUrl: './list-department.component.html',
  styleUrls: ['./list-department.component.css']
})
export class ListDepartmentComponent {
  constructor(
    private _departmentService : DepartmentService,
    private router: Router) { }
  dept: DepartmenetModel = {};

  ngOnInit(): void {
    this.getDepartments();
  }

  getDepartments()
  {
    this._departmentService.getDepartments().subscribe(res=> {
      this.dept = res;
    })
  }
  navigateToAddDepartment()
  {
    this.router.navigate(['/department/add'], {
      queryParams: {},
    });
  }
  navigateToEditDepartment(id: any)
  {
    this.router.navigate(['/department/edit'], {
      queryParams : {id : id}
    });
  }
  deleteDepartment(id: any)
  {
    this._departmentService.deleteDepartment(id).subscribe(res=> {
      this.getDepartments();
    })
  }
}
