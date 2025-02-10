import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NSNHANVIENInfoComponent } from './ns-nhanvieninfo.component';

describe('NSNHANVIENInfoComponent', () => {
  let component: NSNHANVIENInfoComponent;
  let fixture: ComponentFixture<NSNHANVIENInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NSNHANVIENInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NSNHANVIENInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
