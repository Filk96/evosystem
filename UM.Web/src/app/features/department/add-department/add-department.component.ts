import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DepartmenetModel } from 'src/app/core/model/department-model';
import { DepartmentService } from 'src/app/core/shared/services/department.service';

@Component({
  selector: 'app-add-department',
  templateUrl: './add-department.component.html',
  styleUrls: ['./add-department.component.css']
})
export class AddDepartmentComponent {
constructor(
  private _departmentService : DepartmentService,
  private router: Router) { }

dept: DepartmenetModel = {};

addDepartment()
{
  this._departmentService.createDepartment(this.dept).subscribe(res=> {
    this.dept.name = null;
    this.dept.sigla = null;
    this.navigateToList();
  })
}
navigateToList()
  {
    this.router.navigate(['/department/list'], {
      queryParams: {},
    });
  }
}
