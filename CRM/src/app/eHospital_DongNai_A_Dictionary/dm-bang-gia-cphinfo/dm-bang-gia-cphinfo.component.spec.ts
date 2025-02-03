import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMBangGiaCPHInfoComponent } from './dm-bang-gia-cphinfo.component';

describe('DMBangGiaCPHInfoComponent', () => {
  let component: DMBangGiaCPHInfoComponent;
  let fixture: ComponentFixture<DMBangGiaCPHInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMBangGiaCPHInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMBangGiaCPHInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
