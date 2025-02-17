import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML5CV130Component } from './xml5-cv130.component';

describe('XML5CV130Component', () => {
  let component: XML5CV130Component;
  let fixture: ComponentFixture<XML5CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML5CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML5CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
