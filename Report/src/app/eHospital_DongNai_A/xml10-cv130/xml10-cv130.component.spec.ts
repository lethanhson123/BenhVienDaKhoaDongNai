import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML10CV130Component } from './xml10-cv130.component';

describe('XML10CV130Component', () => {
  let component: XML10CV130Component;
  let fixture: ComponentFixture<XML10CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML10CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML10CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
