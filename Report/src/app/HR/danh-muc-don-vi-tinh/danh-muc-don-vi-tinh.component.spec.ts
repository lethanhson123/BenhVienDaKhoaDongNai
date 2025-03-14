import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucDonViTinhComponent } from './danh-muc-don-vi-tinh.component';

describe('DanhMucDonViTinhComponent', () => {
  let component: DanhMucDonViTinhComponent;
  let fixture: ComponentFixture<DanhMucDonViTinhComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucDonViTinhComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucDonViTinhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
