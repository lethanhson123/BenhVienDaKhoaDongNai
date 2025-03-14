import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienInfoComponent } from './hrnhan-vien-info.component';

describe('HRNhanVienInfoComponent', () => {
  let component: HRNhanVienInfoComponent;
  let fixture: ComponentFixture<HRNhanVienInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
