import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RouterModule, Router, ActivatedRoute } from '@angular/router';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatSnackBar, MatSnackBarModule } from '@angular/material/snack-bar';
import { EmployeeCertification } from '../../../core/models/employee-certification.model';
import { ApiService, ReferenceData } from '../../../core/services/api';
import { catchError, forkJoin } from 'rxjs';

@Component({
  selector: 'app-employee-certification-form',
  templateUrl: './employee-certification-form.html',
  styleUrls: ['./employee-certification-form.scss'],
  standalone: true,
  imports: [
    CommonModule,
    ReactiveFormsModule,
    RouterModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatSnackBarModule
  ]
})
export class EmployeeCertificationFormComponent implements OnInit {
  certificationForm: FormGroup;
  isEdit = false;
  id?: number;
  employeeId?: number;

  // Reference data
  employees: ReferenceData[] = [];
  certificationTypes: ReferenceData[] = [];
  issuingAuthorities: ReferenceData[] = [];

  constructor(
    private fb: FormBuilder,
    private apiService: ApiService,
    private router: Router,
    private route: ActivatedRoute,
    private snackBar: MatSnackBar
  ) {
    this.certificationForm = this.fb.group({
      employeeId: ['', Validators.required],
      certificationType: ['', Validators.required],
      certificationNumber: ['', Validators.required],
      issueDate: ['', Validators.required],
      expirationDate: ['', Validators.required],
      issuingAuthority: ['', Validators.required],
      notes: ['']
    });
  }

  ngOnInit(): void {
    this.loadReferenceData();

    this.id = Number(this.route.snapshot.paramMap.get('id'));
    this.employeeId = Number(this.route.snapshot.queryParamMap.get('employeeId'));

    if (this.id) {
      this.isEdit = true;
      this.loadCertification();
    } else if (this.employeeId) {
      this.certificationForm.patchValue({ employeeId: this.employeeId });
    }
  }

  loadReferenceData(): void {
    forkJoin({
      employees: this.apiService.getEmployeeLookup(),
      certificationTypes: this.apiService.getCertificationTypes()
    }).pipe(
      catchError(error => {
        this.snackBar.open('Error loading reference data', 'Close', { duration: 3000 });
        console.error('Error loading reference data:', error);
        throw error;
      })
    ).subscribe(data => {
      this.employees = data.employees;
      this.certificationTypes = data.certificationTypes;
    });
  }

  loadCertification(): void {
    if (this.id) {
      this.apiService.getEmployeeCertification(this.id).subscribe(certification => {
        this.certificationForm.patchValue(certification);
      });
    }
  }

  onSubmit(): void {
    if (this.certificationForm.valid) {
      const certification: EmployeeCertification = this.certificationForm.value;
      
      const request = this.isEdit 
        ? this.apiService.updateEmployeeCertification(this.id!, certification)
        : this.apiService.createEmployeeCertification(certification);

      request.subscribe({
        next: () => {
          this.snackBar.open(
            `Certification successfully ${this.isEdit ? 'updated' : 'created'}`,
            'Close',
            { duration: 3000 }
          );
          this.navigateBack();
        },
        error: (error) => {
          this.snackBar.open(
            'Error saving certification. Please try again.',
            'Close',
            { duration: 3000 }
          );
          console.error('Error saving certification:', error);
        }
      });
    }
  }

  navigateBack(): void {
    const queryParams = this.employeeId ? { employeeId: this.employeeId } : {};
    this.router.navigate(['/certifications'], { queryParams });
  }
}
