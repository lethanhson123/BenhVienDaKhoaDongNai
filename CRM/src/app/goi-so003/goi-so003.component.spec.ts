import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoiSo003Component } from './goi-so003.component';

describe('GoiSo003Component', () => {
  let component: GoiSo003Component;
  let fixture: ComponentFixture<GoiSo003Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoiSo003Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoiSo003Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
