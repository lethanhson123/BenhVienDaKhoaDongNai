import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMLoaiGiaComponent } from './dm-loai-gia.component';

describe('DMLoaiGiaComponent', () => {
  let component: DMLoaiGiaComponent;
  let fixture: ComponentFixture<DMLoaiGiaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMLoaiGiaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMLoaiGiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
