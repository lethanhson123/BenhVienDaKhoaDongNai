import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PhongKhamHienThiComponent } from './phong-kham-hien-thi.component';

describe('PhongKhamHienThiComponent', () => {
  let component: PhongKhamHienThiComponent;
  let fixture: ComponentFixture<PhongKhamHienThiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PhongKhamHienThiComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PhongKhamHienThiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
