import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucThongKeComponent } from './danh-muc-thong-ke.component';

describe('DanhMucThongKeComponent', () => {
  let component: DanhMucThongKeComponent;
  let fixture: ComponentFixture<DanhMucThongKeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucThongKeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucThongKeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
