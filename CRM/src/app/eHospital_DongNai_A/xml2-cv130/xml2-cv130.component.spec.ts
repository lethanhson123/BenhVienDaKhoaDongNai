import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML2CV130Component } from './xml2-cv130.component';

describe('XML2CV130Component', () => {
  let component: XML2CV130Component;
  let fixture: ComponentFixture<XML2CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML2CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML2CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
