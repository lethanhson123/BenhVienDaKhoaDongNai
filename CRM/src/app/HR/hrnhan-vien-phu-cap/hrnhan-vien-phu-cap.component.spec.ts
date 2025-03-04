import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienPhuCapComponent } from './hrnhan-vien-phu-cap.component';

describe('HRNhanVienPhuCapComponent', () => {
  let component: HRNhanVienPhuCapComponent;
  let fixture: ComponentFixture<HRNhanVienPhuCapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienPhuCapComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienPhuCapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
