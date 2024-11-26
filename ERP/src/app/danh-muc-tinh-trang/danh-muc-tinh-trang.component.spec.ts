import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucTinhTrangComponent } from './danh-muc-tinh-trang.component';

describe('DanhMucTinhTrangComponent', () => {
  let component: DanhMucTinhTrangComponent;
  let fixture: ComponentFixture<DanhMucTinhTrangComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucTinhTrangComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucTinhTrangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
