import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucKhuVucComponent } from './danh-muc-khu-vuc.component';

describe('DanhMucKhuVucComponent', () => {
  let component: DanhMucKhuVucComponent;
  let fixture: ComponentFixture<DanhMucKhuVucComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucKhuVucComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucKhuVucComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
