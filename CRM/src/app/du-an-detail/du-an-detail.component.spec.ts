import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DuAnDetailComponent } from './du-an-detail.component';

describe('DuAnDetailComponent', () => {
  let component: DuAnDetailComponent;
  let fixture: ComponentFixture<DuAnDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DuAnDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DuAnDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
