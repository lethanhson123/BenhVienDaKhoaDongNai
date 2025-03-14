import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML12CV130Component } from './xml12-cv130.component';

describe('XML12CV130Component', () => {
  let component: XML12CV130Component;
  let fixture: ComponentFixture<XML12CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML12CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML12CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
