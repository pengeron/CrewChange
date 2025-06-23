import { Routes } from '@angular/router';
import { AdminLayoutComponent } from './layout/admin-layout';

export const routes: Routes = [
  {
    path: '',
    component: AdminLayoutComponent,
    children: [
      {
        path: 'employees',
        loadChildren: () => import('./features/employee/employee-module')
          .then(m => m.EmployeeModule)
      },
      {
        path: 'certifications',
        loadChildren: () => import('./features/employee-certification/employee-certification-module')
          .then(m => m.EmployeeCertificationModule)
      },
      {
        path: '',
        redirectTo: 'employees',
        pathMatch: 'full'
      }
    ]
  }
];
