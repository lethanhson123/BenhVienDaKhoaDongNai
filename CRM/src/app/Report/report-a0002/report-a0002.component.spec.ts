import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportA0002Component } from './report-a0002.component';

describe('ReportA0002Component', () => {
  let component: ReportA0002Component;
  let fixture: ComponentFixture<ReportA0002Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportA0002Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportA0002Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
