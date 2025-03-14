import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMBenhVienComponent } from './dm-benh-vien.component';

describe('DMBenhVienComponent', () => {
  let component: DMBenhVienComponent;
  let fixture: ComponentFixture<DMBenhVienComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMBenhVienComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMBenhVienComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
