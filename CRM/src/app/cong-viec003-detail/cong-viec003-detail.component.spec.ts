import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CongViec003DetailComponent } from './cong-viec003-detail.component';

describe('CongViec003DetailComponent', () => {
  let component: CongViec003DetailComponent;
  let fixture: ComponentFixture<CongViec003DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CongViec003DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CongViec003DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
