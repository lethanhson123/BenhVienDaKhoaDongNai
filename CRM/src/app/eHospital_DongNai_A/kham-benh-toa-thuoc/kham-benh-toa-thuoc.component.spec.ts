import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhamBenhToaThuocComponent } from './kham-benh-toa-thuoc.component';

describe('KhamBenhToaThuocComponent', () => {
  let component: KhamBenhToaThuocComponent;
  let fixture: ComponentFixture<KhamBenhToaThuocComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhamBenhToaThuocComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhamBenhToaThuocComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
