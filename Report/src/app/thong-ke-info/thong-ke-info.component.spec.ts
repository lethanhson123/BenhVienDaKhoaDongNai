import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ThongKeInfoComponent } from './thong-ke-info.component';

describe('ThongKeInfoComponent', () => {
  let component: ThongKeInfoComponent;
  let fixture: ComponentFixture<ThongKeInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ThongKeInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ThongKeInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
