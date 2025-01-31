import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMICDNhomComponent } from './dm-icd-nhom.component';

describe('DMICDNhomComponent', () => {
  let component: DMICDNhomComponent;
  let fixture: ComponentFixture<DMICDNhomComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMICDNhomComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMICDNhomComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
