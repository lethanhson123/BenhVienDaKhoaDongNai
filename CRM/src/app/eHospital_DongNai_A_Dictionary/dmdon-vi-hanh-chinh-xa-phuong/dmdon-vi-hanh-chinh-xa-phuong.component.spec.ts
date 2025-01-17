import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMDonViHanhChinhXaPhuongComponent } from './dmdon-vi-hanh-chinh-xa-phuong.component';

describe('DMDonViHanhChinhXaPhuongComponent', () => {
  let component: DMDonViHanhChinhXaPhuongComponent;
  let fixture: ComponentFixture<DMDonViHanhChinhXaPhuongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMDonViHanhChinhXaPhuongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMDonViHanhChinhXaPhuongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
