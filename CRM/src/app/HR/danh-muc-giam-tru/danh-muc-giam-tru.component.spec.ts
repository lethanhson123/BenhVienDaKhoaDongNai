import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucGiamTruComponent } from './danh-muc-giam-tru.component';

describe('DanhMucGiamTruComponent', () => {
  let component: DanhMucGiamTruComponent;
  let fixture: ComponentFixture<DanhMucGiamTruComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucGiamTruComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucGiamTruComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
