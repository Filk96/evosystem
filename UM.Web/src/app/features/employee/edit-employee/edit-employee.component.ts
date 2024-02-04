import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DepartmenetModel } from 'src/app/core/model/department-model';
import { EmployeeModel } from 'src/app/core/model/employee-models';
import { DepartmentService } from 'src/app/core/shared/services/department.service';
import { EmployeeService } from 'src/app/core/shared/services/employee.service.service';

@Component({
  selector: 'app-edit-employee',
  templateUrl: './edit-employee.component.html',
  styleUrls: ['./edit-employee.component.css']
})
export class EditEmployeeComponent implements OnInit {

  dept: DepartmenetModel = {};
  emp: EmployeeModel = {};
  empId: any;

  constructor(
    private _employeeService : EmployeeService,
    private _departmentService : DepartmentService,
    private router: Router,
    private route : ActivatedRoute)
    {
      this.route.queryParams.subscribe(params => {
        this.empId = params && params.id != null ? parseInt(params.id) : 0;
        this.getEmployeesById(this.empId);
      })
    }


  ngOnInit(): void {
    this.getDepartments();
  }


  getEmployeesById(id: any)
  {
    this._employeeService.getEmployeetById(id).subscribe(res=> {
      this.emp = res;
    })
  }
  updateEmployee()
  {
    this.emp['departmentId'] = parseInt(this.emp.departmentId);
    this._employeeService.updateEmployee(this.emp).subscribe(res=> {
      this.navigateToList();
    })
  }
  getDepartments()
  {
    this._departmentService.getDepartments().subscribe((res: any)=> {
      this.dept = res;

      if(res.length > 0)
      {
        //  this.emp.department = this.emp.id;
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
