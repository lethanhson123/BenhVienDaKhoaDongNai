import { ComponentFixture, TestBed } from '@angular/core/testing';

import { M60Component } from './m60.component';

describe('M60Component', () => {
  let component: M60Component;
  let fixture: ComponentFixture<M60Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ M60Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(M60Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
