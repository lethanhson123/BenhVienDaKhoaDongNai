import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMBenhNhanInfoComponent } from './dm-benh-nhan-info.component';

describe('DMBenhNhanInfoComponent', () => {
  let component: DMBenhNhanInfoComponent;
  let fixture: ComponentFixture<DMBenhNhanInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMBenhNhanInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMBenhNhanInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
