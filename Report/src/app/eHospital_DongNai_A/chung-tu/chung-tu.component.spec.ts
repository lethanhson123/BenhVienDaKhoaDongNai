import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChungTuComponent } from './chung-tu.component';

describe('ChungTuComponent', () => {
  let component: ChungTuComponent;
  let fixture: ComponentFixture<ChungTuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChungTuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChungTuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
