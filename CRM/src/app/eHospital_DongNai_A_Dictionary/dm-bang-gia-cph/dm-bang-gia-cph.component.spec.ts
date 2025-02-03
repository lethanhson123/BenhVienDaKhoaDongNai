import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMBangGiaCPHComponent } from './dm-bang-gia-cph.component';

describe('DMBangGiaCPHComponent', () => {
  let component: DMBangGiaCPHComponent;
  let fixture: ComponentFixture<DMBangGiaCPHComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMBangGiaCPHComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMBangGiaCPHComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
