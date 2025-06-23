import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { MatSnackBar, MatSnackBarModule } from '@angular/material/snack-bar';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { Employee, EmployeeDto } from '../../../core/models/employee.model';
import { ApiService, ReferenceData } from '../../../core/services/api';
import { catchError, forkJoin } from 'rxjs';

@Component({
  selector: 'app-employee-form',
  templateUrl: './employee-form.html',
  styleUrls: ['./employee-form.scss'],
  standalone: true,
  imports: [
    CommonModule,
    RouterModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatIconModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatSnackBarModule
  ]
})
export class EmployeeFormComponent implements OnInit {
  employeeForm!: FormGroup;
  isEditMode = false;
  employeeId?: number;

  // Reference data
  states: ReferenceData[] = [];
  departments: ReferenceData[] = [];
  positions: ReferenceData[] = [];
  employmentStatuses: ReferenceData[] = [];
  maritalStatuses: ReferenceData[] = [];
  genders: ReferenceData[] = [];

  constructor(
    private fb: FormBuilder,
    private apiService: ApiService,
    private route: ActivatedRoute,
    private router: Router,
    private snackBar: MatSnackBar
  ) {
    this.createForm();
  }

  ngOnInit(): void {
    this.loadReferenceData();
    
    this.employeeId = Number(this.route.snapshot.paramMap.get('id'));
    if (this.employeeId) {
      this.isEditMode = true;
      this.loadEmployee(this.employeeId);
    }
  }

  createForm(): void {
    this.employeeForm = this.fb.group({
      employeeNumber: ['', Validators.required],
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      middleName: [''],
      ssn: ['', [Validators.required, Validators.pattern('^\\d{3}-\\d{2}-\\d{4}$')]],
      birthDate: [null, Validators.required],
      hireDate: [null, Validators.required],
      phoneNumber: ['', [Validators.required, Validators.pattern('^\\d{3}-\\d{3}-\\d{4}$')]],
      email: ['', [Validators.required, Validators.email]],
      addressLine1: ['', Validators.required],
      addressLine2: [''],
      city: ['', Validators.required],
      stateId: [null, Validators.required],
      zipCode: ['', [Validators.required, Validators.pattern('^\\d{5}(-\\d{4})?$')]],
      departmentId: [null, Validators.required],
      positionId: [null, Validators.required],
      employmentStatusId: [null, Validators.required],
      maritalStatusId: [null, Validators.required],
      genderId: [null, Validators.required]
    });
  }

  loadReferenceData(): void {
    forkJoin({
      states: this.apiService.getStates(),
      departments: this.apiService.getDepartments(),
      positions: this.apiService.getPositions(),
      employmentStatuses: this.apiService.getEmploymentStatuses(),
      maritalStatuses: this.apiService.getMaritalStatuses(),
      genders: this.apiService.getGenders()
    }).pipe(
      catchError(error => {
        this.snackBar.open('Error loading reference data', 'Close', { duration: 3000 });
        console.error('Error loading reference data:', error);
        throw error;
      })
    ).subscribe(data => {
      this.states = data.states;
      this.departments = data.departments;
      this.positions = data.positions;
      this.employmentStatuses = data.employmentStatuses;
      this.maritalStatuses = data.maritalStatuses;
      this.genders = data.genders;
    });
  }

  loadEmployee(id: number): void {
    this.apiService.getEmployee(id).subscribe(
      (employee: Employee) => {
        this.employeeForm.patchValue(employee);
        // Convert string dates to Date objects for the date pickers
        this.employeeForm.patchValue({
          birthDate: new Date(employee.birthDate),
          hireDate: new Date(employee.hireDate)
        });
      },
      error => {
        this.snackBar.open('Error loading employee', 'Close', { duration: 3000 });
        this.router.navigate(['/employees']);
      }
    );
  }

  onSubmit(): void {
    if (this.employeeForm.valid) {
      const employeeData: EmployeeDto = this.employeeForm.value;
      
      if (this.isEditMode && this.employeeId) {
        this.apiService.updateEmployee(this.employeeId, employeeData).subscribe(
          () => {
            this.snackBar.open('Employee updated successfully', 'Close', { duration: 3000 });
            this.router.navigate(['/employees']);
          },
          error => {
            this.snackBar.open('Error updating employee', 'Close', { duration: 3000 });
          }
        );
      } else {
        this.apiService.createEmployee(employeeData).subscribe(
          () => {
            this.snackBar.open('Employee created successfully', 'Close', { duration: 3000 });
            this.router.navigate(['/employees']);
          },
          error => {
            this.snackBar.open('Error creating employee', 'Close', { duration: 3000 });
          }
        );
      }
    }
  }

  onCancel(): void {
    this.router.navigate(['/employees']);
  }
}
