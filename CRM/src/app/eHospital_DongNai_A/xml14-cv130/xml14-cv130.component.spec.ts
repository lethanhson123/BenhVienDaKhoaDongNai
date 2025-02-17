import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML14CV130Component } from './xml14-cv130.component';

describe('XML14CV130Component', () => {
  let component: XML14CV130Component;
  let fixture: ComponentFixture<XML14CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML14CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML14CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
