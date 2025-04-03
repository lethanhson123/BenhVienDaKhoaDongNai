import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportA0005Component } from './report-a0005.component';

describe('ReportA0005Component', () => {
  let component: ReportA0005Component;
  let fixture: ComponentFixture<ReportA0005Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportA0005Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportA0005Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
