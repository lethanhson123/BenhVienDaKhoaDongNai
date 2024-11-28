import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DuAnQuyetDinhInfoComponent } from './du-an-quyet-dinh-info.component';

describe('DuAnQuyetDinhInfoComponent', () => {
  let component: DuAnQuyetDinhInfoComponent;
  let fixture: ComponentFixture<DuAnQuyetDinhInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DuAnQuyetDinhInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DuAnQuyetDinhInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
