import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucChuyenNganhComponent } from './danh-muc-chuyen-nganh.component';

describe('DanhMucChuyenNganhComponent', () => {
  let component: DanhMucChuyenNganhComponent;
  let fixture: ComponentFixture<DanhMucChuyenNganhComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucChuyenNganhComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucChuyenNganhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
