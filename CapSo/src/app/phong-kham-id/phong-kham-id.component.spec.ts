import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PhongKhamIDComponent } from './phong-kham-id.component';

describe('PhongKhamIDComponent', () => {
  let component: PhongKhamIDComponent;
  let fixture: ComponentFixture<PhongKhamIDComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PhongKhamIDComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PhongKhamIDComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
