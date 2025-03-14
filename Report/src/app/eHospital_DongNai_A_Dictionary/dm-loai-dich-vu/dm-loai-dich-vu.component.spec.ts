import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMLoaiDichVuComponent } from './dm-loai-dich-vu.component';

describe('DMLoaiDichVuComponent', () => {
  let component: DMLoaiDichVuComponent;
  let fixture: ComponentFixture<DMLoaiDichVuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMLoaiDichVuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMLoaiDichVuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
