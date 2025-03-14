import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMICDComponent } from './dm-icd.component';

describe('DMICDComponent', () => {
  let component: DMICDComponent;
  let fixture: ComponentFixture<DMICDComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMICDComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMICDComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
