import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManHinh01Component } from './man-hinh01.component';

describe('ManHinh01Component', () => {
  let component: ManHinh01Component;
  let fixture: ComponentFixture<ManHinh01Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManHinh01Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManHinh01Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
