import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucToChucDaoTaoComponent } from './danh-muc-to-chuc-dao-tao.component';

describe('DanhMucToChucDaoTaoComponent', () => {
  let component: DanhMucToChucDaoTaoComponent;
  let fixture: ComponentFixture<DanhMucToChucDaoTaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucToChucDaoTaoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucToChucDaoTaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
