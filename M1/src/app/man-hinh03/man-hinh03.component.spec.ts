import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManHinh03Component } from './man-hinh03.component';

describe('ManHinh03Component', () => {
  let component: ManHinh03Component;
  let fixture: ComponentFixture<ManHinh03Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManHinh03Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManHinh03Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
