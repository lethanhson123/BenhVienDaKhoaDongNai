import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucMauSacComponent } from './danh-muc-mau-sac.component';

describe('DanhMucMauSacComponent', () => {
  let component: DanhMucMauSacComponent;
  let fixture: ComponentFixture<DanhMucMauSacComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucMauSacComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucMauSacComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
