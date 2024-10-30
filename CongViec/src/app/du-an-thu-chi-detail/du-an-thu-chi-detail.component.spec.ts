import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DuAnThuChiDetailComponent } from './du-an-thu-chi-detail.component';

describe('DuAnThuChiDetailComponent', () => {
  let component: DuAnThuChiDetailComponent;
  let fixture: ComponentFixture<DuAnThuChiDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DuAnThuChiDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DuAnThuChiDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
