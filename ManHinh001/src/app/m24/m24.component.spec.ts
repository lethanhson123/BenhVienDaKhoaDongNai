import { ComponentFixture, TestBed } from '@angular/core/testing';

import { M24Component } from './m24.component';

describe('M24Component', () => {
  let component: M24Component;
  let fixture: ComponentFixture<M24Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ M24Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(M24Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
