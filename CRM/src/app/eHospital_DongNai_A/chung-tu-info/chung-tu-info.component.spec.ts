import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChungTuInfoComponent } from './chung-tu-info.component';

describe('ChungTuInfoComponent', () => {
  let component: ChungTuInfoComponent;
  let fixture: ComponentFixture<ChungTuInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChungTuInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChungTuInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
