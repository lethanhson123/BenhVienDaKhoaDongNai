import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManHinhTapTinDinhKemComponent } from './man-hinh-tap-tin-dinh-kem.component';

describe('ManHinhTapTinDinhKemComponent', () => {
  let component: ManHinhTapTinDinhKemComponent;
  let fixture: ComponentFixture<ManHinhTapTinDinhKemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ManHinhTapTinDinhKemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ManHinhTapTinDinhKemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
