import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HienThi02Component } from './hien-thi02.component';

describe('HienThi02Component', () => {
  let component: HienThi02Component;
  let fixture: ComponentFixture<HienThi02Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HienThi02Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HienThi02Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
