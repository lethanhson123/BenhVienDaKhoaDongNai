import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportDictionary0001Component } from './report-dictionary0001.component';

describe('ReportDictionary0001Component', () => {
  let component: ReportDictionary0001Component;
  let fixture: ComponentFixture<ReportDictionary0001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportDictionary0001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportDictionary0001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
