import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhamBenhVaoVienComponent } from './kham-benh-vao-vien.component';

describe('KhamBenhVaoVienComponent', () => {
  let component: KhamBenhVaoVienComponent;
  let fixture: ComponentFixture<KhamBenhVaoVienComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhamBenhVaoVienComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhamBenhVaoVienComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
