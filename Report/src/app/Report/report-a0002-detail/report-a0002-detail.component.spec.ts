import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReportA0002DetailComponent } from './report-a0002-detail.component';

describe('ReportA0002DetailComponent', () => {
  let component: ReportA0002DetailComponent;
  let fixture: ComponentFixture<ReportA0002DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReportA0002DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ReportA0002DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
