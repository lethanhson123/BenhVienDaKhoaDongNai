import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRLichCongTacInfoComponent } from './hrlich-cong-tac-info.component';

describe('HRLichCongTacInfoComponent', () => {
  let component: HRLichCongTacInfoComponent;
  let fixture: ComponentFixture<HRLichCongTacInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRLichCongTacInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRLichCongTacInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
