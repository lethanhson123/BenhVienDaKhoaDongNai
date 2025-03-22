import { ComponentFixture, TestBed } from '@angular/core/testing';

import { M40Component } from './m40.component';

describe('M40Component', () => {
  let component: M40Component;
  let fixture: ComponentFixture<M40Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ M40Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(M40Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
