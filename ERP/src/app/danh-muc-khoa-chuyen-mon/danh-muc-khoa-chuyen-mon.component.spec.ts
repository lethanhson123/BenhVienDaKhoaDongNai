import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucKhoaChuyenMonComponent } from './danh-muc-khoa-chuyen-mon.component';

describe('DanhMucKhoaChuyenMonComponent', () => {
  let component: DanhMucKhoaChuyenMonComponent;
  let fixture: ComponentFixture<DanhMucKhoaChuyenMonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucKhoaChuyenMonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucKhoaChuyenMonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
