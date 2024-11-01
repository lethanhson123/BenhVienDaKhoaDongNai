import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DuAnInfoComponent } from './du-an-info.component';

describe('DuAnInfoComponent', () => {
  let component: DuAnInfoComponent;
  let fixture: ComponentFixture<DuAnInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DuAnInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DuAnInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
