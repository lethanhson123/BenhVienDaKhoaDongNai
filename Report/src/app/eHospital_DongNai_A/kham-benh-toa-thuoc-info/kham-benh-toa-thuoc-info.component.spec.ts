import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhamBenhToaThuocInfoComponent } from './kham-benh-toa-thuoc-info.component';

describe('KhamBenhToaThuocInfoComponent', () => {
  let component: KhamBenhToaThuocInfoComponent;
  let fixture: ComponentFixture<KhamBenhToaThuocInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhamBenhToaThuocInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhamBenhToaThuocInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
