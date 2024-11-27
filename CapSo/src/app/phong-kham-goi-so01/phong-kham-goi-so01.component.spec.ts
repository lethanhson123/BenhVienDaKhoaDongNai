import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PhongKhamGoiSo01Component } from './phong-kham-goi-so01.component';

describe('PhongKhamGoiSo01Component', () => {
  let component: PhongKhamGoiSo01Component;
  let fixture: ComponentFixture<PhongKhamGoiSo01Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PhongKhamGoiSo01Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PhongKhamGoiSo01Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
