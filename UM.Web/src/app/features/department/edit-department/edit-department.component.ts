import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { DepartmenetModel } from 'src/app/core/model/department-model';
import { DepartmentService } from 'src/app/core/shared/services/department.service';

@Component({
  selector: 'app-edit-department',
  templateUrl: './edit-department.component.html',
  styleUrls: ['./edit-department.component.css']
})
export class EditDepartmentComponent implements OnInit {

  deptId : any;
  dept: DepartmenetModel = {};

  constructor(
    private _departmentService : DepartmentService,
    private router: Router,
    private route : ActivatedRoute,)
    {
      this.route.queryParams.subscribe(params => {
        this.deptId = params && params.id != null ? parseInt(params.id) : 0;
        this.getDepartmentsById(this.deptId);
      })
    }
  ngOnInit(): void {
    // this.getDepartmentsById(this.deptId);
  }

  getDepartmentsById(id: any)
  {
    this._departmentService.getDepartmentById(id).subscribe(res=> {
      this.dept = res;
    })
  }
  editDepartment()
  {
    this._departmentService.updateDepartment(this.dept).subscribe(res=> {
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
