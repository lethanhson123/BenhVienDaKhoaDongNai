import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMLoaiBenhAnComponent } from './dm-loai-benh-an.component';

describe('DMLoaiBenhAnComponent', () => {
  let component: DMLoaiBenhAnComponent;
  let fixture: ComponentFixture<DMLoaiBenhAnComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMLoaiBenhAnComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMLoaiBenhAnComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
