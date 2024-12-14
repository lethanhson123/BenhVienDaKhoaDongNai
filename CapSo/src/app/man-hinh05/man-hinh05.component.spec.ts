import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManHinh05Component } from './man-hinh05.component';

describe('ManHinh05Component', () => {
  let component: ManHinh05Component;
  let fixture: ComponentFixture<ManHinh05Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManHinh05Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManHinh05Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
