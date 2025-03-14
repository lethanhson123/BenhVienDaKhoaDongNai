import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML15CV130DetailComponent } from './xml15-cv130-detail.component';

describe('XML15CV130DetailComponent', () => {
  let component: XML15CV130DetailComponent;
  let fixture: ComponentFixture<XML15CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML15CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML15CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
