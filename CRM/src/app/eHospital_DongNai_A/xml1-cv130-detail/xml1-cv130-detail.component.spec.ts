import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML1CV130DetailComponent } from './xml1-cv130-detail.component';

describe('XML1CV130DetailComponent', () => {
  let component: XML1CV130DetailComponent;
  let fixture: ComponentFixture<XML1CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML1CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML1CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
