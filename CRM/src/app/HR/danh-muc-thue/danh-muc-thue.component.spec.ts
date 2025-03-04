import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DanhMucThueComponent } from './danh-muc-thue.component';

describe('DanhMucThueComponent', () => {
  let component: DanhMucThueComponent;
  let fixture: ComponentFixture<DanhMucThueComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DanhMucThueComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DanhMucThueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
