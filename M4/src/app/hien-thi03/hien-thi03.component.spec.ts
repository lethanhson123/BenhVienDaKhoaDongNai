import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HienThi03Component } from './hien-thi03.component';

describe('HienThi03Component', () => {
  let component: HienThi03Component;
  let fixture: ComponentFixture<HienThi03Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HienThi03Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HienThi03Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
