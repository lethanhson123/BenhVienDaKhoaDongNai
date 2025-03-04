import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienComponent } from './hrnhan-vien.component';

describe('HRNhanVienComponent', () => {
  let component: HRNhanVienComponent;
  let fixture: ComponentFixture<HRNhanVienComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
