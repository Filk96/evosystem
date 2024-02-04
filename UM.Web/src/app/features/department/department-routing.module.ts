import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListDepartmentComponent } from './list-department/list-department.component';
import { AddDepartmentComponent } from './add-department/add-department.component';
import { EditDepartmentComponent } from './edit-department/edit-department.component';

const routes: Routes =
[
  {
    path: '', component: ListDepartmentComponent
  },
  {
    path: 'add', component: AddDepartmentComponent
  },
  {
    path: 'edit', component: EditDepartmentComponent
  },
  {
    path: 'list', component: ListDepartmentComponent
  },
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DepartmentRoutingModule { }
