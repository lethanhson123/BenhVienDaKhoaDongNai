import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KhamSucKhoeComponent } from './kham-suc-khoe.component';

describe('KhamSucKhoeComponent', () => {
  let component: KhamSucKhoeComponent;
  let fixture: ComponentFixture<KhamSucKhoeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KhamSucKhoeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(KhamSucKhoeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
