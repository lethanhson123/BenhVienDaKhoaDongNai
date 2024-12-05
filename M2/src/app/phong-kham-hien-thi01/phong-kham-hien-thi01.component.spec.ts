import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PhongKhamHienThi01Component } from './phong-kham-hien-thi01.component';

describe('PhongKhamHienThi01Component', () => {
  let component: PhongKhamHienThi01Component;
  let fixture: ComponentFixture<PhongKhamHienThi01Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PhongKhamHienThi01Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PhongKhamHienThi01Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
