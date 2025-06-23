import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee, EmployeeDto } from '../models/employee.model';
import { EmployeeCertification, EmployeeCertificationDto } from '../models/employee-certification.model';

export interface ReferenceData {
  id: number;
  name: string;
}

@Injectable({
  providedIn: 'root'
})
export class ApiService {
  private baseUrl = 'http://localhost:5000/api'; // Adjust this to match your API URL

  constructor(private http: HttpClient) {}

  // Employee endpoints
  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(`${this.baseUrl}/employees`);
  }

  getEmployee(id: number): Observable<Employee> {
    return this.http.get<Employee>(`${this.baseUrl}/employees/${id}`);
  }

  createEmployee(employee: EmployeeDto): Observable<Employee> {
    return this.http.post<Employee>(`${this.baseUrl}/employees`, employee);
  }

  updateEmployee(id: number, employee: EmployeeDto): Observable<Employee> {
    return this.http.put<Employee>(`${this.baseUrl}/employees/${id}`, employee);
  }

  deleteEmployee(id: number): Observable<void> {
    return this.http.delete<void>(`${this.baseUrl}/employees/${id}`);
  }

  // Employee Certification endpoints
  getEmployeeCertifications(employeeId?: number): Observable<EmployeeCertification[]> {
    const url = employeeId 
      ? `${this.baseUrl}/employees/${employeeId}/certifications`
      : `${this.baseUrl}/employee-certifications`;
    return this.http.get<EmployeeCertification[]>(url);
  }

  getEmployeeCertification(id: number): Observable<EmployeeCertification> {
    return this.http.get<EmployeeCertification>(`${this.baseUrl}/employee-certifications/${id}`);
  }

  createEmployeeCertification(certification: EmployeeCertificationDto): Observable<EmployeeCertification> {
    return this.http.post<EmployeeCertification>(`${this.baseUrl}/employee-certifications`, certification);
  }

  updateEmployeeCertification(id: number, certification: EmployeeCertificationDto): Observable<EmployeeCertification> {
    return this.http.put<EmployeeCertification>(`${this.baseUrl}/employee-certifications/${id}`, certification);
  }

  deleteEmployeeCertification(id: number): Observable<void> {
    return this.http.delete<void>(`${this.baseUrl}/employee-certifications/${id}`);
  }

  // Reference data endpoints
  getStates(): Observable<ReferenceData[]> {
    return this.http.get<ReferenceData[]>(`${this.baseUrl}/states`);
  }

  getDepartments(): Observable<ReferenceData[]> {
    return this.http.get<ReferenceData[]>(`${this.baseUrl}/departments`);
  }

  getPositions(): Observable<ReferenceData[]> {
    return this.http.get<ReferenceData[]>(`${this.baseUrl}/positions`);
  }

  getEmploymentStatuses(): Observable<ReferenceData[]> {
    return this.http.get<ReferenceData[]>(`${this.baseUrl}/employment-statuses`);
  }

  getMaritalStatuses(): Observable<ReferenceData[]> {
    return this.http.get<ReferenceData[]>(`${this.baseUrl}/marital-statuses`);
  }

  getGenders(): Observable<ReferenceData[]> {
    return this.http.get<ReferenceData[]>(`${this.baseUrl}/genders`);
  }

  getCertificationTypes(): Observable<ReferenceData[]> {
    return this.http.get<ReferenceData[]>(`${this.baseUrl}/certification-types`);
  }

  getEmployeeLookup(): Observable<ReferenceData[]> {
    return this.http.get<ReferenceData[]>(`${this.baseUrl}/employees/lookup`);
  }
}
