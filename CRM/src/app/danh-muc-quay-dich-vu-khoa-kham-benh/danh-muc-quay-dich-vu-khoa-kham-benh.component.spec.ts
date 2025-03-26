import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucQuayDichVuKhoaKhamBenhComponent } from './danh-muc-quay-dich-vu-khoa-kham-benh.component';

describe('DanhMucQuayDichVuKhoaKhamBenhComponent', () => {
  let component: DanhMucQuayDichVuKhoaKhamBenhComponent;
  let fixture: ComponentFixture<DanhMucQuayDichVuKhoaKhamBenhComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucQuayDichVuKhoaKhamBenhComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucQuayDichVuKhoaKhamBenhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
