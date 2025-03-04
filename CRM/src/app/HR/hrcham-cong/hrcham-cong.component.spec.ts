import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRChamCongComponent } from './hrcham-cong.component';

describe('HRChamCongComponent', () => {
  let component: HRChamCongComponent;
  let fixture: ComponentFixture<HRChamCongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRChamCongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRChamCongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
