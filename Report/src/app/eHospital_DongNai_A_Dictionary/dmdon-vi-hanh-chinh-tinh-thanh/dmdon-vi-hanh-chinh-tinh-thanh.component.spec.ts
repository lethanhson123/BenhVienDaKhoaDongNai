import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMDonViHanhChinhTinhThanhComponent } from './dmdon-vi-hanh-chinh-tinh-thanh.component';

describe('DMDonViHanhChinhTinhThanhComponent', () => {
  let component: DMDonViHanhChinhTinhThanhComponent;
  let fixture: ComponentFixture<DMDonViHanhChinhTinhThanhComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMDonViHanhChinhTinhThanhComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMDonViHanhChinhTinhThanhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
