import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucHopDongComponent } from './danh-muc-hop-dong.component';

describe('DanhMucHopDongComponent', () => {
  let component: DanhMucHopDongComponent;
  let fixture: ComponentFixture<DanhMucHopDongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucHopDongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucHopDongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
