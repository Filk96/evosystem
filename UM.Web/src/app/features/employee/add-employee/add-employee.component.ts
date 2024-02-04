import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DepartmenetModel } from 'src/app/core/model/department-model';
import { EmployeeModel } from 'src/app/core/model/employee-models';
import { DepartmentService } from 'src/app/core/shared/services/department.service';
import { EmployeeService } from 'src/app/core/shared/services/employee.service.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  dept: DepartmenetModel = {};

  constructor(
    private _employeeService : EmployeeService,
    private _departmentService : DepartmentService,
    private router: Router) { }


  ngOnInit(): void {
    this.getDepartments();
  }

  emp: EmployeeModel = {};

  addEmployee()
  {
     this.emp['departmentId'] = parseInt(this.emp.department);
    this._employeeService.createEmployee(this.emp).subscribe(res=> {
      this.navigateToList();
    })
  }
  getDepartments()
  {
    this._departmentService.getDepartments().subscribe((res: any)=> {
      this.dept = res;

      if(res.length > 0)
      {
         this.emp.department = res[0].id;
        // this.emp.rg = null;
      }
    })
  }

  navigateToList()
    {
      this.router.navigate(['/employee/list'], {
        queryParams: {},
      });
    }
  }
