import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMDichVuInfoComponent } from './dm-dich-vu-info.component';

describe('DMDichVuInfoComponent', () => {
  let component: DMDichVuInfoComponent;
  let fixture: ComponentFixture<DMDichVuInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMDichVuInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMDichVuInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
