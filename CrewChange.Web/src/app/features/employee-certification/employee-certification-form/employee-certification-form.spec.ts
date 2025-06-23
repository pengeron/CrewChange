import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeeCertificationForm } from './employee-certification-form';

describe('EmployeeCertificationForm', () => {
  let component: EmployeeCertificationForm;
  let fixture: ComponentFixture<EmployeeCertificationForm>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EmployeeCertificationForm]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmployeeCertificationForm);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
