import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRChamCongChiTietComponent } from './hrcham-cong-chi-tiet.component';

describe('HRChamCongChiTietComponent', () => {
  let component: HRChamCongChiTietComponent;
  let fixture: ComponentFixture<HRChamCongChiTietComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRChamCongChiTietComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRChamCongChiTietComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
