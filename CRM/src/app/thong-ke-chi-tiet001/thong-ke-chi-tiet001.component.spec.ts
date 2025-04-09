import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThongKeChiTiet001Component } from './thong-ke-chi-tiet001.component';

describe('ThongKeChiTiet001Component', () => {
  let component: ThongKeChiTiet001Component;
  let fixture: ComponentFixture<ThongKeChiTiet001Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ThongKeChiTiet001Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ThongKeChiTiet001Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
