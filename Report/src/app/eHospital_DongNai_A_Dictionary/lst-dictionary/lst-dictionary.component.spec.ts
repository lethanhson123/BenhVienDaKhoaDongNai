import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LstDictionaryComponent } from './lst-dictionary.component';

describe('LstDictionaryComponent', () => {
  let component: LstDictionaryComponent;
  let fixture: ComponentFixture<LstDictionaryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LstDictionaryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LstDictionaryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
