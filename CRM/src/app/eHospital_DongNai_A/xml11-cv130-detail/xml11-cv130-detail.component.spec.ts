import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML11CV130DetailComponent } from './xml11-cv130-detail.component';

describe('XML11CV130DetailComponent', () => {
  let component: XML11CV130DetailComponent;
  let fixture: ComponentFixture<XML11CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML11CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML11CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
