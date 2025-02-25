import { ComponentFixture, TestBed } from '@angular/core/testing';

import { XMLCV130TagComponent } from './xmlcv130-tag.component';

describe('XMLCV130TagComponent', () => {
  let component: XMLCV130TagComponent;
  let fixture: ComponentFixture<XMLCV130TagComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ XMLCV130TagComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(XMLCV130TagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
