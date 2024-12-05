import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PhongKhamGoiSoComponent } from './phong-kham-goi-so.component';

describe('PhongKhamGoiSoComponent', () => {
  let component: PhongKhamGoiSoComponent;
  let fixture: ComponentFixture<PhongKhamGoiSoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PhongKhamGoiSoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PhongKhamGoiSoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
