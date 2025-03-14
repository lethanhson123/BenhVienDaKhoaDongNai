import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucHopDongInfoComponent } from './danh-muc-hop-dong-info.component';

describe('DanhMucHopDongInfoComponent', () => {
  let component: DanhMucHopDongInfoComponent;
  let fixture: ComponentFixture<DanhMucHopDongInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucHopDongInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucHopDongInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
