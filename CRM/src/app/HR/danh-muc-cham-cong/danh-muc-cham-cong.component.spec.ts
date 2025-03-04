import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucChamCongComponent } from './danh-muc-cham-cong.component';

describe('DanhMucChamCongComponent', () => {
  let component: DanhMucChamCongComponent;
  let fixture: ComponentFixture<DanhMucChamCongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucChamCongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucChamCongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
