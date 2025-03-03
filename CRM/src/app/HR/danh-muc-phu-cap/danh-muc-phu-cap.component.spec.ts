import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucPhuCapComponent } from './danh-muc-phu-cap.component';

describe('DanhMucPhuCapComponent', () => {
  let component: DanhMucPhuCapComponent;
  let fixture: ComponentFixture<DanhMucPhuCapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucPhuCapComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucPhuCapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
