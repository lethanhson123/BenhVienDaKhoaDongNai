import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML8CV130Component } from './xml8-cv130.component';

describe('XML8CV130Component', () => {
  let component: XML8CV130Component;
  let fixture: ComponentFixture<XML8CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML8CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML8CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
