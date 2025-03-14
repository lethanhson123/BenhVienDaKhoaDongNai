import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMBangGiaInfoComponent } from './dm-bang-gia-info.component';

describe('DMBangGiaInfoComponent', () => {
  let component: DMBangGiaInfoComponent;
  let fixture: ComponentFixture<DMBangGiaInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMBangGiaInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMBangGiaInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
