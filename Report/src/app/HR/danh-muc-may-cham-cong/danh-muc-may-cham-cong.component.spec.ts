import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucMayChamCongComponent } from './danh-muc-may-cham-cong.component';

describe('DanhMucMayChamCongComponent', () => {
  let component: DanhMucMayChamCongComponent;
  let fixture: ComponentFixture<DanhMucMayChamCongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucMayChamCongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucMayChamCongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
