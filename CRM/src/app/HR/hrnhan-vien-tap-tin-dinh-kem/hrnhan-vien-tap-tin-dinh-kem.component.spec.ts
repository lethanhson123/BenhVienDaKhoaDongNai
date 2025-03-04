import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienTapTinDinhKemComponent } from './hrnhan-vien-tap-tin-dinh-kem.component';

describe('HRNhanVienTapTinDinhKemComponent', () => {
  let component: HRNhanVienTapTinDinhKemComponent;
  let fixture: ComponentFixture<HRNhanVienTapTinDinhKemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienTapTinDinhKemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienTapTinDinhKemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
