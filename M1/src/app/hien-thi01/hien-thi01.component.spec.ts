import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HienThi01Component } from './hien-thi01.component';

describe('HienThi01Component', () => {
  let component: HienThi01Component;
  let fixture: ComponentFixture<HienThi01Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HienThi01Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HienThi01Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
