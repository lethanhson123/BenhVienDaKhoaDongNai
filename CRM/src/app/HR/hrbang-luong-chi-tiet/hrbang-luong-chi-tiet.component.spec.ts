import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRBangLuongChiTietComponent } from './hrbang-luong-chi-tiet.component';

describe('HRBangLuongChiTietComponent', () => {
  let component: HRBangLuongChiTietComponent;
  let fixture: ComponentFixture<HRBangLuongChiTietComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRBangLuongChiTietComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRBangLuongChiTietComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
