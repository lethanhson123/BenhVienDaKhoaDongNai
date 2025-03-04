import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienHopDongComponent } from './hrnhan-vien-hop-dong.component';

describe('HRNhanVienHopDongComponent', () => {
  let component: HRNhanVienHopDongComponent;
  let fixture: ComponentFixture<HRNhanVienHopDongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienHopDongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienHopDongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
