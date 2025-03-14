import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML8CV130DetailComponent } from './xml8-cv130-detail.component';

describe('XML8CV130DetailComponent', () => {
  let component: XML8CV130DetailComponent;
  let fixture: ComponentFixture<XML8CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML8CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML8CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
