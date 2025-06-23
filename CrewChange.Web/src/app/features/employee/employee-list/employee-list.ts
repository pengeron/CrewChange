import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatSort, MatSortModule } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { Employee } from '../../../core/models/employee.model';
import { ApiService } from '../../../core/services/api';
import { ConfirmDialogComponent } from '../../../shared/components/dialogs/confirm-dialog';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.html',
  styleUrls: ['./employee-list.scss'],
  standalone: true,
  imports: [
    CommonModule,
    RouterModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatButtonModule,
    MatIconModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatDialogModule
  ]
})
export class EmployeeListComponent implements OnInit {
  displayedColumns: string[] = [
    'employeeNumber',
    'firstName',
    'lastName',
    'email',
    'phoneNumber',
    'department',
    'position',
    'actions'
  ];
  dataSource!: MatTableDataSource<Employee>;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private apiService: ApiService,
    private dialog: MatDialog,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.loadEmployees();
  }

  loadEmployees(): void {
    this.apiService.getEmployees().subscribe(employees => {
      this.dataSource = new MatTableDataSource(employees);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });
  }

  applyFilter(event: Event): void {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  editEmployee(id: number): void {
    this.router.navigate(['/employees/edit', id]);
  }

  deleteEmployee(id: number): void {
    const dialogRef = this.dialog.open(ConfirmDialogComponent, {
      data: {
        title: 'Confirm Delete',
        message: 'Are you sure you want to delete this employee?'
      }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.apiService.deleteEmployee(id).subscribe(() => {
          this.loadEmployees();
        });
      }
    });
  }

  createEmployee(): void {
    this.router.navigate(['/employees/create']);
  }
}
