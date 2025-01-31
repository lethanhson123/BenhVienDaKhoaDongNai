import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMDichVuComponent } from './dm-dich-vu.component';

describe('DMDichVuComponent', () => {
  let component: DMDichVuComponent;
  let fixture: ComponentFixture<DMDichVuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMDichVuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMDichVuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
