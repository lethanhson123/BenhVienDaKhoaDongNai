import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML11CV130Component } from './xml11-cv130.component';

describe('XML11CV130Component', () => {
  let component: XML11CV130Component;
  let fixture: ComponentFixture<XML11CV130Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML11CV130Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML11CV130Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
