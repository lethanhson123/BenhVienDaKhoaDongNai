import { ComponentFixture, TestBed } from '@angular/core/testing';

import { M120Component } from './m120.component';

describe('M120Component', () => {
  let component: M120Component;
  let fixture: ComponentFixture<M120Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ M120Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(M120Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
