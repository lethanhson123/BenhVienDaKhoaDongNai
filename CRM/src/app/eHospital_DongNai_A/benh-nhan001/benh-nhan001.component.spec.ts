import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BenhNhan001Component } from './benh-nhan001.component';

describe('BenhNhan001Component', () => {
  let component: BenhNhan001Component;
  let fixture: ComponentFixture<BenhNhan001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BenhNhan001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BenhNhan001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
