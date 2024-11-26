import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucTinhThanhToaDoComponent } from './danh-muc-tinh-thanh-toa-do.component';

describe('DanhMucTinhThanhToaDoComponent', () => {
  let component: DanhMucTinhThanhToaDoComponent;
  let fixture: ComponentFixture<DanhMucTinhThanhToaDoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucTinhThanhToaDoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucTinhThanhToaDoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
