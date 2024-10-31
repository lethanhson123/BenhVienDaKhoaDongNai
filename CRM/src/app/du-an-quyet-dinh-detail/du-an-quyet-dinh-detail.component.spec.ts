import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DuAnQuyetDinhDetailComponent } from './du-an-quyet-dinh-detail.component';

describe('DuAnQuyetDinhDetailComponent', () => {
  let component: DuAnQuyetDinhDetailComponent;
  let fixture: ComponentFixture<DuAnQuyetDinhDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DuAnQuyetDinhDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DuAnQuyetDinhDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
