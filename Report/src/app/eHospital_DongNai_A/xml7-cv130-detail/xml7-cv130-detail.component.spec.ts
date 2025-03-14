import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML7CV130DetailComponent } from './xml7-cv130-detail.component';

describe('XML7CV130DetailComponent', () => {
  let component: XML7CV130DetailComponent;
  let fixture: ComponentFixture<XML7CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML7CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML7CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
