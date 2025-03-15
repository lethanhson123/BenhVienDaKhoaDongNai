import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportA0002InfoComponent } from './report-a0002-info.component';

describe('ReportA0002InfoComponent', () => {
  let component: ReportA0002InfoComponent;
  let fixture: ComponentFixture<ReportA0002InfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportA0002InfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportA0002InfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
