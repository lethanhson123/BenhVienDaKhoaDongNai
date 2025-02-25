import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XML2CV130DetailComponent } from './xml2-cv130-detail.component';

describe('XML2CV130DetailComponent', () => {
  let component: XML2CV130DetailComponent;
  let fixture: ComponentFixture<XML2CV130DetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XML2CV130DetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XML2CV130DetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
