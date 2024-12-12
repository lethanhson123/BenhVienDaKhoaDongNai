import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucQuayDichVuComponent } from './danh-muc-quay-dich-vu.component';

describe('DanhMucQuayDichVuComponent', () => {
  let component: DanhMucQuayDichVuComponent;
  let fixture: ComponentFixture<DanhMucQuayDichVuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucQuayDichVuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucQuayDichVuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
