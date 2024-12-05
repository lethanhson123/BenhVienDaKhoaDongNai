import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HienThi0201Component } from './hien-thi0201.component';

describe('HienThi0201Component', () => {
  let component: HienThi0201Component;
  let fixture: ComponentFixture<HienThi0201Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HienThi0201Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HienThi0201Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
