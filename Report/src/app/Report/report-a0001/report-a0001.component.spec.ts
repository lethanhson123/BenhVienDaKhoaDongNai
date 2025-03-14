import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportA0001Component } from './report-a0001.component';

describe('ReportA0001Component', () => {
  let component: ReportA0001Component;
  let fixture: ComponentFixture<ReportA0001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportA0001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportA0001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
