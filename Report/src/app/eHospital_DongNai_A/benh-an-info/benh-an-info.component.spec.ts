import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BenhAnInfoComponent } from './benh-an-info.component';

describe('BenhAnInfoComponent', () => {
  let component: BenhAnInfoComponent;
  let fixture: ComponentFixture<BenhAnInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BenhAnInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BenhAnInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
