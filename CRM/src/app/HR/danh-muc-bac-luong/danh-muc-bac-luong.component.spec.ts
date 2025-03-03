import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucBacLuongComponent } from './danh-muc-bac-luong.component';

describe('DanhMucBacLuongComponent', () => {
  let component: DanhMucBacLuongComponent;
  let fixture: ComponentFixture<DanhMucBacLuongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucBacLuongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucBacLuongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
