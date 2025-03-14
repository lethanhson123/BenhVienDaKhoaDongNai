import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManHinhThongBaoComponent } from './man-hinh-thong-bao.component';

describe('ManHinhThongBaoComponent', () => {
  let component: ManHinhThongBaoComponent;
  let fixture: ComponentFixture<ManHinhThongBaoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManHinhThongBaoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManHinhThongBaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
