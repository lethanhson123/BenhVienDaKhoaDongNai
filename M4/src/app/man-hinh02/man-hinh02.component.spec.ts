import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManHinh02Component } from './man-hinh02.component';

describe('ManHinh02Component', () => {
  let component: ManHinh02Component;
  let fixture: ComponentFixture<ManHinh02Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManHinh02Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManHinh02Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
