import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucBieuMauDetailComponent } from './danh-muc-bieu-mau-detail.component';

describe('DanhMucBieuMauDetailComponent', () => {
  let component: DanhMucBieuMauDetailComponent;
  let fixture: ComponentFixture<DanhMucBieuMauDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucBieuMauDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucBieuMauDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
