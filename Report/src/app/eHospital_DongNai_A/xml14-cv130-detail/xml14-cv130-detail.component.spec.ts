import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML14CV130DetailComponent } from './xml14-cv130-detail.component';

describe('XML14CV130DetailComponent', () => {
  let component: XML14CV130DetailComponent;
  let fixture: ComponentFixture<XML14CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML14CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML14CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
