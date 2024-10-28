import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucPhongBanComponent } from './danh-muc-phong-ban.component';

describe('DanhMucPhongBanComponent', () => {
  let component: DanhMucPhongBanComponent;
  let fixture: ComponentFixture<DanhMucPhongBanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucPhongBanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucPhongBanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
