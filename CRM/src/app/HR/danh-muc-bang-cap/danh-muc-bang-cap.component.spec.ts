import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucBangCapComponent } from './danh-muc-bang-cap.component';

describe('DanhMucBangCapComponent', () => {
  let component: DanhMucBangCapComponent;
  let fixture: ComponentFixture<DanhMucBangCapComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucBangCapComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucBangCapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
