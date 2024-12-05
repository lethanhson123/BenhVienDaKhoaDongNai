import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManHinh04Component } from './man-hinh04.component';

describe('ManHinh04Component', () => {
  let component: ManHinh04Component;
  let fixture: ComponentFixture<ManHinh04Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManHinh04Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManHinh04Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
