import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CongViec002DetailComponent } from './cong-viec002-detail.component';

describe('CongViec002DetailComponent', () => {
  let component: CongViec002DetailComponent;
  let fixture: ComponentFixture<CongViec002DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CongViec002DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CongViec002DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
