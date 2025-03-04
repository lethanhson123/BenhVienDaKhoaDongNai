import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucLuongCoBanComponent } from './danh-muc-luong-co-ban.component';

describe('DanhMucLuongCoBanComponent', () => {
  let component: DanhMucLuongCoBanComponent;
  let fixture: ComponentFixture<DanhMucLuongCoBanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucLuongCoBanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucLuongCoBanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
