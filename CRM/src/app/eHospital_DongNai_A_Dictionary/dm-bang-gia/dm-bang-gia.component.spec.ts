import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMBangGiaComponent } from './dm-bang-gia.component';

describe('DMBangGiaComponent', () => {
  let component: DMBangGiaComponent;
  let fixture: ComponentFixture<DMBangGiaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMBangGiaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMBangGiaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
