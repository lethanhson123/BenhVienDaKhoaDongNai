import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhamBenhVaoVienInfoComponent } from './kham-benh-vao-vien-info.component';

describe('KhamBenhVaoVienInfoComponent', () => {
  let component: KhamBenhVaoVienInfoComponent;
  let fixture: ComponentFixture<KhamBenhVaoVienInfoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhamBenhVaoVienInfoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhamBenhVaoVienInfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
