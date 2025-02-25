import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML6CV130DetailComponent } from './xml6-cv130-detail.component';

describe('XML6CV130DetailComponent', () => {
  let component: XML6CV130DetailComponent;
  let fixture: ComponentFixture<XML6CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML6CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML6CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
