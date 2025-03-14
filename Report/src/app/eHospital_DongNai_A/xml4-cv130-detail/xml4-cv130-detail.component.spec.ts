import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML4CV130DetailComponent } from './xml4-cv130-detail.component';

describe('XML4CV130DetailComponent', () => {
  let component: XML4CV130DetailComponent;
  let fixture: ComponentFixture<XML4CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML4CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML4CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
