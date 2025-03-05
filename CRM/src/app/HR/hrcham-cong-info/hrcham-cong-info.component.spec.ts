import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HRChamCongInfoComponent } from './hrcham-cong-info.component';

describe('HRChamCongInfoComponent', () => {
  let component: HRChamCongInfoComponent;
  let fixture: ComponentFixture<HRChamCongInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HRChamCongInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HRChamCongInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
