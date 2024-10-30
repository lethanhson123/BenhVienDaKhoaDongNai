import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucHinhThucThanhToanComponent } from './danh-muc-hinh-thuc-thanh-toan.component';

describe('DanhMucHinhThucThanhToanComponent', () => {
  let component: DanhMucHinhThucThanhToanComponent;
  let fixture: ComponentFixture<DanhMucHinhThucThanhToanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucHinhThucThanhToanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucHinhThucThanhToanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
