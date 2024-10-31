import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CongViec001Component } from './cong-viec001.component';

describe('CongViec001Component', () => {
  let component: CongViec001Component;
  let fixture: ComponentFixture<CongViec001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CongViec001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CongViec001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
