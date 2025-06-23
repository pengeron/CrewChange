import { TestBed } from '@angular/core/testing';

import { EmployeeCertification } from './employee-certification';

describe('EmployeeCertification', () => {
  let service: EmployeeCertification;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EmployeeCertification);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
