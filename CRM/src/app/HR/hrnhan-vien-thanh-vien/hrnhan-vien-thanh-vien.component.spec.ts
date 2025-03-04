import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienThanhVienComponent } from './hrnhan-vien-thanh-vien.component';

describe('HRNhanVienThanhVienComponent', () => {
  let component: HRNhanVienThanhVienComponent;
  let fixture: ComponentFixture<HRNhanVienThanhVienComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienThanhVienComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienThanhVienComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
