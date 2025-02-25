import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML9CV130DetailComponent } from './xml9-cv130-detail.component';

describe('XML9CV130DetailComponent', () => {
  let component: XML9CV130DetailComponent;
  let fixture: ComponentFixture<XML9CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML9CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML9CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
