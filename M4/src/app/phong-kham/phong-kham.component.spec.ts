import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PhongKhamComponent } from './phong-kham.component';

describe('PhongKhamComponent', () => {
  let component: PhongKhamComponent;
  let fixture: ComponentFixture<PhongKhamComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PhongKhamComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PhongKhamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});