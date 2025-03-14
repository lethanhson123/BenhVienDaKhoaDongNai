import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML4CV130Component } from './xml4-cv130.component';

describe('XML4CV130Component', () => {
  let component: XML4CV130Component;
  let fixture: ComponentFixture<XML4CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML4CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML4CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
