import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRBangLuongComponent } from './hrbang-luong.component';

describe('HRBangLuongComponent', () => {
  let component: HRBangLuongComponent;
  let fixture: ComponentFixture<HRBangLuongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRBangLuongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRBangLuongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
