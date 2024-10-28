import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CongViecDetail001Component } from './cong-viec-detail001.component';

describe('CongViecDetail001Component', () => {
  let component: CongViecDetail001Component;
  let fixture: ComponentFixture<CongViecDetail001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CongViecDetail001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CongViecDetail001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
