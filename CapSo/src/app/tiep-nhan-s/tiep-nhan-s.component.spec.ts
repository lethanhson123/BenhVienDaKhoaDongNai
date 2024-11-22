import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TiepNhanSComponent } from './tiep-nhan-s.component';

describe('TiepNhanSComponent', () => {
  let component: TiepNhanSComponent;
  let fixture: ComponentFixture<TiepNhanSComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TiepNhanSComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TiepNhanSComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
