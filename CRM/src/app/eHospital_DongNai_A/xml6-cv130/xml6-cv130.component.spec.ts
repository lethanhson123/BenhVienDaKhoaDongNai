import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML6CV130Component } from './xml6-cv130.component';

describe('XML6CV130Component', () => {
  let component: XML6CV130Component;
  let fixture: ComponentFixture<XML6CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML6CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML6CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
