import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML12CV130DetailComponent } from './xml12-cv130-detail.component';

describe('XML12CV130DetailComponent', () => {
  let component: XML12CV130DetailComponent;
  let fixture: ComponentFixture<XML12CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML12CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML12CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
