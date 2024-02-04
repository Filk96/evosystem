import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SharedAppModule } from 'src/app/core/shared/shared.module';
import { AddDepartmentComponent } from './add-department/add-department.component';
import { ListDepartmentComponent } from './list-department/list-department.component';
import { EditDepartmentComponent } from './edit-department/edit-department.component';
import { DepartmentRoutingModule } from './department-routing.module';


@NgModule({
  declarations: [
    AddDepartmentComponent,
    ListDepartmentComponent,
    EditDepartmentComponent
  ],
  imports: [
    CommonModule,
    SharedAppModule,
    DepartmentRoutingModule
  ]
})
export class DepartmentModule { }
