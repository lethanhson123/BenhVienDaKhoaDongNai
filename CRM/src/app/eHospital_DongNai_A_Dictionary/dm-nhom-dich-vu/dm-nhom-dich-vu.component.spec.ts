import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMNhomDichVuComponent } from './dm-nhom-dich-vu.component';

describe('DMNhomDichVuComponent', () => {
  let component: DMNhomDichVuComponent;
  let fixture: ComponentFixture<DMNhomDichVuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMNhomDichVuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMNhomDichVuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
