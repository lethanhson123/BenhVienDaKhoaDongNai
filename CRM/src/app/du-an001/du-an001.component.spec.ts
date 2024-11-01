import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DuAn001Component } from './du-an001.component';

describe('DuAn001Component', () => {
  let component: DuAn001Component;
  let fixture: ComponentFixture<DuAn001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DuAn001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DuAn001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
