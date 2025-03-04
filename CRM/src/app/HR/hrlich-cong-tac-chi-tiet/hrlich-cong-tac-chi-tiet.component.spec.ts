import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRLichCongTacChiTietComponent } from './hrlich-cong-tac-chi-tiet.component';

describe('HRLichCongTacChiTietComponent', () => {
  let component: HRLichCongTacChiTietComponent;
  let fixture: ComponentFixture<HRLichCongTacChiTietComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRLichCongTacChiTietComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRLichCongTacChiTietComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
