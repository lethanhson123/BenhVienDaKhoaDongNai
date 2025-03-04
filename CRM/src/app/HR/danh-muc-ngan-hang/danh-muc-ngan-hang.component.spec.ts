import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucNganHangComponent } from './danh-muc-ngan-hang.component';

describe('DanhMucNganHangComponent', () => {
  let component: DanhMucNganHangComponent;
  let fixture: ComponentFixture<DanhMucNganHangComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucNganHangComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucNganHangComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
