import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMICDChuongComponent } from './dm-icd-chuong.component';

describe('DMICDChuongComponent', () => {
  let component: DMICDChuongComponent;
  let fixture: ComponentFixture<DMICDChuongComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMICDChuongComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMICDChuongComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
