export interface Employee {
  id: number;
  employeeNumber: string;
  firstName: string;
  lastName: string;
  middleName?: string;
  ssn: string;
  birthDate: Date;
  hireDate: Date;
  phoneNumber: string;
  email: string;
  addressLine1: string;
  addressLine2?: string;
  city: string;
  stateId: number;
  zipCode: string;
  departmentId: number;
  positionId: number;
  profileImageUrl?: string;
  employmentStatusId: number;
  maritalStatusId: number;
  genderId: number;
}

export interface EmployeeDto extends Omit<Employee, 'id'> {
  id?: number;
}
