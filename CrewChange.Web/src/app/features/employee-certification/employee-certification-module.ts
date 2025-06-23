import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeCertificationListComponent } from './employee-certification-list/employee-certification-list';
import { EmployeeCertificationFormComponent } from './employee-certification-form/employee-certification-form';

const routes: Routes = [
  { path: '', component: EmployeeCertificationListComponent },
  { path: 'create', component: EmployeeCertificationFormComponent },
  { path: 'edit/:id', component: EmployeeCertificationFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmployeeCertificationModule { }
