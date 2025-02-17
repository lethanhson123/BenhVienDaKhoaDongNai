import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML7CV130Component } from './xml7-cv130.component';

describe('XML7CV130Component', () => {
  let component: XML7CV130Component;
  let fixture: ComponentFixture<XML7CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML7CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML7CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
