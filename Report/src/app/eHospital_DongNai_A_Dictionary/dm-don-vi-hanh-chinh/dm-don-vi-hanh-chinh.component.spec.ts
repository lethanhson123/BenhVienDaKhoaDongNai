import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMDonViHanhChinhComponent } from './dm-don-vi-hanh-chinh.component';

describe('DMDonViHanhChinhComponent', () => {
  let component: DMDonViHanhChinhComponent;
  let fixture: ComponentFixture<DMDonViHanhChinhComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMDonViHanhChinhComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMDonViHanhChinhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
