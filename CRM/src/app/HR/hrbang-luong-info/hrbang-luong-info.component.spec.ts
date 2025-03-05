import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRBangLuongInfoComponent } from './hrbang-luong-info.component';

describe('HRBangLuongInfoComponent', () => {
  let component: HRBangLuongInfoComponent;
  let fixture: ComponentFixture<HRBangLuongInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRBangLuongInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRBangLuongInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
