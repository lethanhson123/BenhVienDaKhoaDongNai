import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoiSo002Component } from './goi-so002.component';

describe('GoiSo002Component', () => {
  let component: GoiSo002Component;
  let fixture: ComponentFixture<GoiSo002Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoiSo002Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoiSo002Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
