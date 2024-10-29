import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CongViec002Component } from './cong-viec002.component';

describe('CongViec002Component', () => {
  let component: CongViec002Component;
  let fixture: ComponentFixture<CongViec002Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CongViec002Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CongViec002Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
