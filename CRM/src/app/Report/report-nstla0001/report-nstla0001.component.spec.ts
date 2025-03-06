import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportNSTLA0001Component } from './report-nstla0001.component';

describe('ReportNSTLA0001Component', () => {
  let component: ReportNSTLA0001Component;
  let fixture: ComponentFixture<ReportNSTLA0001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportNSTLA0001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportNSTLA0001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
