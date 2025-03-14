import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML3CV130DetailComponent } from './xml3-cv130-detail.component';

describe('XML3CV130DetailComponent', () => {
  let component: XML3CV130DetailComponent;
  let fixture: ComponentFixture<XML3CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML3CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML3CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
