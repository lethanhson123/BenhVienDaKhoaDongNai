import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML1CV130Component } from './xml1-cv130.component';

describe('XML1CV130Component', () => {
  let component: XML1CV130Component;
  let fixture: ComponentFixture<XML1CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML1CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML1CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
