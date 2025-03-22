import { ComponentFixture, TestBed } from '@angular/core/testing';

import { M12Component } from './m12.component';

describe('M12Component', () => {
  let component: M12Component;
  let fixture: ComponentFixture<M12Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ M12Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(M12Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
