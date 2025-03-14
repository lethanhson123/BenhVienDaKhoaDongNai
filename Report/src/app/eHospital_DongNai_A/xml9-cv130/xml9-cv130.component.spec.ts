import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML9CV130Component } from './xml9-cv130.component';

describe('XML9CV130Component', () => {
  let component: XML9CV130Component;
  let fixture: ComponentFixture<XML9CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML9CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML9CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
