import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HienThi04Component } from './hien-thi04.component';

describe('HienThi04Component', () => {
  let component: HienThi04Component;
  let fixture: ComponentFixture<HienThi04Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HienThi04Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HienThi04Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
