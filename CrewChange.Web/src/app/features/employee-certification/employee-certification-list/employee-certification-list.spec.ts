import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeCertificationList } from './employee-certification-list';

describe('EmployeeCertificationList', () => {
  let component: EmployeeCertificationList;
  let fixture: ComponentFixture<EmployeeCertificationList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EmployeeCertificationList]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmployeeCertificationList);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
