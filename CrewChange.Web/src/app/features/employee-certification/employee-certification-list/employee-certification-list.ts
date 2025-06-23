import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Router, ActivatedRoute } from '@angular/router';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatSort, MatSortModule } from '@angular/material/sort';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { MatDialog, MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { EmployeeCertification } from '../../../core/models/employee-certification.model';
import { ApiService } from '../../../core/services/api';
import { ConfirmDialogComponent } from '../../../shared/components/dialogs/confirm-dialog';

@Component({
  selector: 'app-employee-certification-list',
  templateUrl: './employee-certification-list.html',
  styleUrls: ['./employee-certification-list.scss'],
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
export class EmployeeCertificationListComponent implements OnInit {
  displayedColumns: string[] = [
    'employeeId',
    'certificationType',
    'certificationNumber',
    'issueDate',
    'expirationDate',
    'issuingAuthority',
    'actions'
  ];
  dataSource!: MatTableDataSource<EmployeeCertification>;
  employeeId?: number;

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  constructor(
    private apiService: ApiService,
    private dialog: MatDialog,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.employeeId = Number(this.route.snapshot.queryParamMap.get('employeeId'));
    this.loadCertifications();
  }

  loadCertifications(): void {
    this.apiService.getEmployeeCertifications(this.employeeId).subscribe(certifications => {
      this.dataSource = new MatTableDataSource(certifications);
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

  editCertification(id: number): void {
    this.router.navigate(['/certifications/edit', id]);
  }

  deleteCertification(id: number): void {
    const dialogRef = this.dialog.open(ConfirmDialogComponent, {
      data: {
        title: 'Confirm Delete',
        message: 'Are you sure you want to delete this certification?'
      }
    });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.apiService.deleteEmployeeCertification(id).subscribe(() => {
          this.loadCertifications();
        });
      }
    });
  }

  createCertification(): void {
    const queryParams = this.employeeId ? { employeeId: this.employeeId } : {};
    this.router.navigate(['/certifications/create'], { queryParams });
  }
}
