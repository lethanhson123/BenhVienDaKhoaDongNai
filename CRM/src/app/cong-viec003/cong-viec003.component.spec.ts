import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CongViec003Component } from './cong-viec003.component';

describe('CongViec003Component', () => {
  let component: CongViec003Component;
  let fixture: ComponentFixture<CongViec003Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CongViec003Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CongViec003Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
