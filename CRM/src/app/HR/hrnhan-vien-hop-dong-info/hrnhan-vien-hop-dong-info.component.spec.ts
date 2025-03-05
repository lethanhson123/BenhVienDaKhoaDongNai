import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRNhanVienHopDongInfoComponent } from './hrnhan-vien-hop-dong-info.component';

describe('HRNhanVienHopDongInfoComponent', () => {
  let component: HRNhanVienHopDongInfoComponent;
  let fixture: ComponentFixture<HRNhanVienHopDongInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRNhanVienHopDongInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRNhanVienHopDongInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
