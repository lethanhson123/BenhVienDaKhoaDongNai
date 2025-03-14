import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMICDCommonComponent } from './dm-icd-common.component';

describe('DMICDCommonComponent', () => {
  let component: DMICDCommonComponent;
  let fixture: ComponentFixture<DMICDCommonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMICDCommonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMICDCommonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
