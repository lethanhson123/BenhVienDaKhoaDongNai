import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuanLyCongViecComponent } from './quan-ly-cong-viec.component';

describe('QuanLyCongViecComponent', () => {
  let component: QuanLyCongViecComponent;
  let fixture: ComponentFixture<QuanLyCongViecComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuanLyCongViecComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuanLyCongViecComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
