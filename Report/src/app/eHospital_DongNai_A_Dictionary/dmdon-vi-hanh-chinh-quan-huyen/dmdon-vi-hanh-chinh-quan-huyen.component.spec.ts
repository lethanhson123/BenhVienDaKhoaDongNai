import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DMDonViHanhChinhQuanHuyenComponent } from './dmdon-vi-hanh-chinh-quan-huyen.component';

describe('DMDonViHanhChinhQuanHuyenComponent', () => {
  let component: DMDonViHanhChinhQuanHuyenComponent;
  let fixture: ComponentFixture<DMDonViHanhChinhQuanHuyenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DMDonViHanhChinhQuanHuyenComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DMDonViHanhChinhQuanHuyenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
