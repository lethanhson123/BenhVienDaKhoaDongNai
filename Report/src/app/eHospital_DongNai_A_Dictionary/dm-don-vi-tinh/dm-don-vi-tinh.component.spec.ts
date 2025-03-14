import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMDonViTinhComponent } from './dm-don-vi-tinh.component';

describe('DMDonViTinhComponent', () => {
  let component: DMDonViTinhComponent;
  let fixture: ComponentFixture<DMDonViTinhComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMDonViTinhComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMDonViTinhComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
