import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TiepNhan2025Component } from './tiep-nhan2025.component';

describe('TiepNhan2025Component', () => {
  let component: TiepNhan2025Component;
  let fixture: ComponentFixture<TiepNhan2025Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TiepNhan2025Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TiepNhan2025Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
