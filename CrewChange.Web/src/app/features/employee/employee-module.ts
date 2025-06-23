import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeListComponent } from './employee-list/employee-list';
import { EmployeeFormComponent } from './employee-form/employee-form';

const routes: Routes = [
  { path: '', component: EmployeeListComponent },
  { path: 'create', component: EmployeeFormComponent },
  { path: 'edit/:id', component: EmployeeFormComponent }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes),
    EmployeeListComponent,
    EmployeeFormComponent
  ]
})
export class EmployeeModule { }
