import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML5CV130DetailComponent } from './xml5-cv130-detail.component';

describe('XML5CV130DetailComponent', () => {
  let component: XML5CV130DetailComponent;
  let fixture: ComponentFixture<XML5CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML5CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML5CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
