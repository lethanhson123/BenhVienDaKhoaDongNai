import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhamBenhNgoaiTru2025Component } from './kham-benh-ngoai-tru2025.component';

describe('KhamBenhNgoaiTru2025Component', () => {
  let component: KhamBenhNgoaiTru2025Component;
  let fixture: ComponentFixture<KhamBenhNgoaiTru2025Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhamBenhNgoaiTru2025Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhamBenhNgoaiTru2025Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
