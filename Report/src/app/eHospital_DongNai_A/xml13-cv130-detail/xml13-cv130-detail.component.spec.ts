import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML13CV130DetailComponent } from './xml13-cv130-detail.component';

describe('XML13CV130DetailComponent', () => {
  let component: XML13CV130DetailComponent;
  let fixture: ComponentFixture<XML13CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML13CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML13CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
