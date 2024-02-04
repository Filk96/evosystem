import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeModel } from 'src/app/core/model/employee-models';

import { EmployeeService } from 'src/app/core/shared/services/employee.service.service';

@Component({
  selector: 'app-list-employee',
  templateUrl: './list-employee.component.html',
  styleUrls: ['./list-employee.component.css']
})
export class ListEmployeeComponent {
  constructor(
    private _employeeService : EmployeeService,
    private router: Router) { }
  dept: EmployeeModel = {};

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees()
  {
    this._employeeService.getEmployees().subscribe(res=> {
      this.dept = res;
    })
  }
  navigateToAddEmployee()
  {
    this.router.navigate(['/employee/add'], {
      queryParams: {},
    });
  }
  navigateToEditEmployee(id: any)
  {
    this.router.navigate(['/employee/edit'], {
      queryParams : {id : id}
    });
  }
  deleteEmployee(id: any)
  {
    this._employeeService.deleteEmployee(id).subscribe(res=> {
      this.getEmployees();
    })
  }
}
