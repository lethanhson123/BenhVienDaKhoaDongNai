import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucBieuMauInfoComponent } from './danh-muc-bieu-mau-info.component';

describe('DanhMucBieuMauInfoComponent', () => {
  let component: DanhMucBieuMauInfoComponent;
  let fixture: ComponentFixture<DanhMucBieuMauInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucBieuMauInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucBieuMauInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
