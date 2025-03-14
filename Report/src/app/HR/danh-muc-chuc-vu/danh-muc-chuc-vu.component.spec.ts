import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucChucVuComponent } from './danh-muc-chuc-vu.component';

describe('DanhMucChucVuComponent', () => {
  let component: DanhMucChucVuComponent;
  let fixture: ComponentFixture<DanhMucChucVuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucChucVuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucChucVuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
