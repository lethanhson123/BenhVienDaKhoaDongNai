import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucBenhVienComponent } from './danh-muc-benh-vien.component';

describe('DanhMucBenhVienComponent', () => {
  let component: DanhMucBenhVienComponent;
  let fixture: ComponentFixture<DanhMucBenhVienComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucBenhVienComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucBenhVienComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
