import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML10CV130DetailComponent } from './xml10-cv130-detail.component';

describe('XML10CV130DetailComponent', () => {
  let component: XML10CV130DetailComponent;
  let fixture: ComponentFixture<XML10CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML10CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML10CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
