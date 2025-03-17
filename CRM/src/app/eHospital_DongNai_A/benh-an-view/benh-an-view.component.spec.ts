import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BenhAnViewComponent } from './benh-an-view.component';

describe('BenhAnViewComponent', () => {
  let component: BenhAnViewComponent;
  let fixture: ComponentFixture<BenhAnViewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BenhAnViewComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BenhAnViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
