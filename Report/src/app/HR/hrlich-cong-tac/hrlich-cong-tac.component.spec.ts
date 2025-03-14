import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRLichCongTacComponent } from './hrlich-cong-tac.component';

describe('HRLichCongTacComponent', () => {
  let component: HRLichCongTacComponent;
  let fixture: ComponentFixture<HRLichCongTacComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRLichCongTacComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRLichCongTacComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
