import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoiSo001Component } from './goi-so001.component';

describe('GoiSo001Component', () => {
  let component: GoiSo001Component;
  let fixture: ComponentFixture<GoiSo001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoiSo001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoiSo001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
