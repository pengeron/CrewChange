export interface EmployeeCertification {
  id: number;
  employeeId: number;
  certificationType: number;
  certificationNumber: string;
  issueDate: Date;
  expirationDate: Date;
  issuingAuthority: string;
  documentUrl?: string;
}

export interface EmployeeCertificationDto extends Omit<EmployeeCertification, 'id'> {
  id?: number;
}
