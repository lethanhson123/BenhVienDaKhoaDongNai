import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BHYTComponent } from './bhyt.component';

describe('BHYTComponent', () => {
  let component: BHYTComponent;
  let fixture: ComponentFixture<BHYTComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BHYTComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BHYTComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
