import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMBenhNhanComponent } from './dm-benh-nhan.component';

describe('DMBenhNhanComponent', () => {
  let component: DMBenhNhanComponent;
  let fixture: ComponentFixture<DMBenhNhanComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMBenhNhanComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMBenhNhanComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
