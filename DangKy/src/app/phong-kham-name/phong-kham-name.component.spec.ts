import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PhongKhamNameComponent } from './phong-kham-name.component';

describe('PhongKhamNameComponent', () => {
  let component: PhongKhamNameComponent;
  let fixture: ComponentFixture<PhongKhamNameComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PhongKhamNameComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PhongKhamNameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
