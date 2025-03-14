import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NSNHANVIENComponent } from './ns-nhanvien.component';

describe('NSNHANVIENComponent', () => {
  let component: NSNHANVIENComponent;
  let fixture: ComponentFixture<NSNHANVIENComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NSNHANVIENComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NSNHANVIENComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
