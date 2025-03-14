import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML3CV130Component } from './xml3-cv130.component';

describe('XML3CV130Component', () => {
  let component: XML3CV130Component;
  let fixture: ComponentFixture<XML3CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML3CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML3CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
