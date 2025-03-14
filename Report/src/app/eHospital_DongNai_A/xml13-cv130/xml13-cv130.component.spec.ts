import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML13CV130Component } from './xml13-cv130.component';

describe('XML13CV130Component', () => {
  let component: XML13CV130Component;
  let fixture: ComponentFixture<XML13CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML13CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML13CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
