import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManHinh0201Component } from './man-hinh0201.component';

describe('ManHinh0201Component', () => {
  let component: ManHinh0201Component;
  let fixture: ComponentFixture<ManHinh0201Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManHinh0201Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManHinh0201Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
