import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucBieuMauComponent } from './danh-muc-bieu-mau.component';

describe('DanhMucBieuMauComponent', () => {
  let component: DanhMucBieuMauComponent;
  let fixture: ComponentFixture<DanhMucBieuMauComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucBieuMauComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucBieuMauComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
