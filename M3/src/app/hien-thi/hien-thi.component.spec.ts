import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HienThiComponent } from './hien-thi.component';

describe('HienThiComponent', () => {
  let component: HienThiComponent;
  let fixture: ComponentFixture<HienThiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HienThiComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HienThiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
