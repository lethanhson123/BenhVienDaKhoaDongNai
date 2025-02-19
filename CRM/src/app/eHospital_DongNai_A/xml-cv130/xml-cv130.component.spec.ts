import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XMLCV130Component } from './xml-cv130.component';

describe('XMLCV130Component', () => {
  let component: XMLCV130Component;
  let fixture: ComponentFixture<XMLCV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XMLCV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XMLCV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
