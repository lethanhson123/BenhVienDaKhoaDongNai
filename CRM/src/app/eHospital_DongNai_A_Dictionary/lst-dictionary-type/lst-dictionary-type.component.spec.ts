import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LstDictionaryTypeComponent } from './lst-dictionary-type.component';

describe('LstDictionaryTypeComponent', () => {
  let component: LstDictionaryTypeComponent;
  let fixture: ComponentFixture<LstDictionaryTypeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LstDictionaryTypeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LstDictionaryTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
