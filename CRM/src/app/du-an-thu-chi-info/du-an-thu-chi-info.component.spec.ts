import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DuAnThuChiInfoComponent } from './du-an-thu-chi-info.component';

describe('DuAnThuChiInfoComponent', () => {
  let component: DuAnThuChiInfoComponent;
  let fixture: ComponentFixture<DuAnThuChiInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DuAnThuChiInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DuAnThuChiInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
