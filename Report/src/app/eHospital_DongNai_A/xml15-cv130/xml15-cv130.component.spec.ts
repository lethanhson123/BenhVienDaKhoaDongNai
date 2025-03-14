import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML15CV130Component } from './xml15-cv130.component';

describe('XML15CV130Component', () => {
  let component: XML15CV130Component;
  let fixture: ComponentFixture<XML15CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML15CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML15CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
