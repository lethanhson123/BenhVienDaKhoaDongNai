import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucPhongKhamComponent } from './danh-muc-phong-kham.component';

describe('DanhMucPhongKhamComponent', () => {
  let component: DanhMucPhongKhamComponent;
  let fixture: ComponentFixture<DanhMucPhongKhamComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucPhongKhamComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucPhongKhamComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
