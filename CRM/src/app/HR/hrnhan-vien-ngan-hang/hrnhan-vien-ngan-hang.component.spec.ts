import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienNganHangComponent } from './hrnhan-vien-ngan-hang.component';

describe('HRNhanVienNganHangComponent', () => {
  let component: HRNhanVienNganHangComponent;
  let fixture: ComponentFixture<HRNhanVienNganHangComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienNganHangComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienNganHangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
