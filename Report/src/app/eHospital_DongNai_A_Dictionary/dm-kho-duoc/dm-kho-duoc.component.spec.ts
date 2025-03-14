import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMKhoDuocComponent } from './dm-kho-duoc.component';

describe('DMKhoDuocComponent', () => {
  let component: DMKhoDuocComponent;
  let fixture: ComponentFixture<DMKhoDuocComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMKhoDuocComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMKhoDuocComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
