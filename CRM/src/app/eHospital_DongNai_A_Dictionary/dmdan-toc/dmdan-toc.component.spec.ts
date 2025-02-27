import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMDanTocComponent } from './dmdan-toc.component';

describe('DMDanTocComponent', () => {
  let component: DMDanTocComponent;
  let fixture: ComponentFixture<DMDanTocComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMDanTocComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMDanTocComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
