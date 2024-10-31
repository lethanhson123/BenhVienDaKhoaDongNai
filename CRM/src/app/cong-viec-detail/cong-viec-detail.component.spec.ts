import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CongViecDetailComponent } from './cong-viec-detail.component';

describe('CongViecDetailComponent', () => {
  let component: CongViecDetailComponent;
  let fixture: ComponentFixture<CongViecDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CongViecDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CongViecDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
