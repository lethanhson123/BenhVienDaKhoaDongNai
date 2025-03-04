import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienBangCapComponent } from './hrnhan-vien-bang-cap.component';

describe('HRNhanVienBangCapComponent', () => {
  let component: HRNhanVienBangCapComponent;
  let fixture: ComponentFixture<HRNhanVienBangCapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienBangCapComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienBangCapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
